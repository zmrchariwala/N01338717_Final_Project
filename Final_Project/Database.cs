using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Final_Project
{
    public class Database
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database_name { get { return "page_management"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString is something that we use to connect to a database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database_name
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public void addpage(pages pg)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            
            string query = "insert into pages(pagetitle,pagebody,pagedate,pageauthor,pagestatus) values('{0}','{1}',now(),'{2}','Published')";
            query = string.Format(query, pg.Getpagetitle(),pg.Getpagebody(),pg.Getpageauthor());
            MySqlCommand cmd = new MySqlCommand();
            cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }
        public List<Dictionary<String, String>> search(string query)
        {
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            //string query = "select * from pages where pagestatus like 'Publish' order by pageid";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader resultset = cmd.ExecuteReader();
           
            
            while (resultset.Read())
                {
                    Dictionary<String,String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for(int i = 0; i < resultset.FieldCount; i++)
                    {
                    //str = resultset.GetString(i); 
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                        
                    }
                    
                    ResultSet.Add(Row);
                }//end row
                resultset.Close();
            return ResultSet;
        }
        
        public List<Dictionary<String, String>> searchpage(string id)
        {
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            string query = "select * from pages where pageid="+id+";";
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader resultset = cmd.ExecuteReader();
            string str = "";

            while (resultset.Read())
            {
                Dictionary<String, String> Row = new Dictionary<String, String>();
                //for every column in the row
                for (int i = 0; i < resultset.FieldCount; i++)
                {
                    //str = resultset.GetString(i); 
                    Row.Add(resultset.GetName(i), resultset.GetString(i));

                }

                ResultSet.Add(Row);
            }//end row
            resultset.Close();
            return ResultSet;
        }
        public void deletepage(string id)
        {
            
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            string query = "delete from pages" +" where pageid =" + id;
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();
        }
        public void updatepage(string id,pages pg)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            string query = "update pages SET pagetitle = '{0}', pagebody = '{1}',pageauthor = '{2}' where pageid = {3};";
            query = string.Format(query,pg.Getpagetitle(),pg.Getpagebody(),pg.Getpageauthor(),id);
            //MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();

        }
        public void updatestatus(string id,int count)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            string query = "update pages SET pagestatus = '{0}' where pageid = {1};";
            if (count == 1)
            {
                
                query = string.Format(query, "Published", id);
                
            }
            else if(count == 2)
            {
                //string query = "update pages SET pagestatus = '{0}' where pageid = {1};";
                query = string.Format(query, "Unpublish", id);
            }
            
            //MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            cmd.ExecuteNonQuery();

        }
    }
}
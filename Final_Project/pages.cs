using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project
{
    public class pages
    {
        private string pagetitle;
        private string pagebody;
        private string pageauthor;

        public string Getpagetitle()
        {
            return pagetitle;
        }
        public string Getpagebody()
        {
            return pagebody;
        }public string Getpageauthor()
        {
            return pageauthor;
        }
        public void Setpagetitle(string value)
        {
            pagetitle = value;
        }
        public void Setpagebody(string value)
        {
            pagebody = value;
        }
        public void Setpageauthor(string value)
        {
            pageauthor = value;
        }


    }
}
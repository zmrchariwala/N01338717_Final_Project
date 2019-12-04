<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editpage.aspx.cs" Inherits="Final_Project.Editpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table id="table1" runat="server">
        <tr>
            <td><asp:Label runat="server">Page Title:</asp:Label></td>
            <td><asp:TextBox runat="server" ID="page_title"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server">Page body:</asp:Label></td>
            <td><asp:TextBox ID="page_body" TextMode="MultiLine" Rows="10" Columns="40" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><button onclick="">Submit</button></td>
        </tr>
    </table>

    
</asp:Content>

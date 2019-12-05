<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editpage.aspx.cs" Inherits="Final_Project.Editpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table id="table1" runat="server">
        <tr>
            <td><asp:Label runat="server">Page Title:</asp:Label></td>
            <td><asp:TextBox runat="server" ID="page_title"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="page_title" runat="server" ForeColor="Red" Text="Please enter page title"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server">Page body:</asp:Label></td>
            <td><asp:TextBox ID="page_body" TextMode="MultiLine" Rows="10" Columns="40" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="page_body" runat="server" ForeColor="Red" Text="Please enter page body"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server">Page Author:</asp:Label></td>
            <td><asp:TextBox runat="server" ID="page_author"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="page_author" runat="server" ForeColor="Red" Text="Please enter page title"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" Text="Update" CssClass="btn btn-primary" /></td>
        </tr>
    </table>

    
</asp:Content>

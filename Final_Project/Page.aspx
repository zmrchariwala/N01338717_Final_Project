<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="Final_Project.Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align:center;">Page Content</h2>
    <div id="viewpage" runat="server">

    </div>
    <asp:Button runat="server" CssClass="btn btn-primary" OnClick="publish" ID="publishbutton" Text="Publish" />
    <asp:Button runat="server" CssClass="btn btn-primary" OnClick="unpublish" ID="unpublishbutton" Text="Unpublish" />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Deletepage.aspx.cs" Inherits="Final_Project.Deletepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div><h2>Do you really wanna delete this page?</h2></div>
    <div style="text-align:center;">
        <asp:Button runat="server" CssClass="btn btn-primary" Text="Delete"  OnClick="delete" />
        <asp:Button runat="server" CssClass="btn btn-primary" Text="No"  OnClick="nodelete" />
       
    </div>
</asp:Content>

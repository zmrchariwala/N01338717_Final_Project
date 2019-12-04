<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
    <div>
        <asp:Label runat="server">Search your page</asp:Label>
        <asp:TextBox runat="server" ID="search"></asp:TextBox>
        <asp:Button CssClass="btn btn-primary" runat="server" OnClick="searchpage" Text="Search" />
    </div>
    
<div id="table" runat="server">

</div>
    <div ID="add_button">
        <asp:Button  runat="server" CssClass="btn btn-primary" PostBackUrl="~/Addpage.aspx" Text="Add Page" />

    </div>
        </div>
</asp:Content>

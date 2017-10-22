<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SQL_Conncetion._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        <asp:GridView ID="UsersGridView" runat="server" 
            onrowdatabound="UsersGridView_RowDataBound">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

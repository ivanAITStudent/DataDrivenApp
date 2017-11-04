<%@ Page Title="Tester Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Tester.aspx.cs" Inherits="Tester" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
                <asp:Label ID="headerTitle_lbl" runat="server" Text="Tester Page"></asp:Label>

    </div>

        <asp:PlaceHolder ID="tester_plc" runat="server"></asp:PlaceHolder>


    <footer>
        <asp:Label ID="debug_lbl" runat="server" Text=""></asp:Label>
    </footer>
</asp:Content>

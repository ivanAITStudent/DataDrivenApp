<%@ Page Title="Take A Survey" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="TakeSurvey.aspx.cs" Inherits="TakeSurvey" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
                <asp:Label ID="headerTitle_lbl" runat="server" Text="Take A Survey"></asp:Label>

    </div>

        <asp:PlaceHolder ID="surveySet_plc" runat="server"></asp:PlaceHolder>


    <footer>
        <asp:Label ID="debug_lbl" runat="server" Text=""></asp:Label>
    </footer>
</asp:Content>

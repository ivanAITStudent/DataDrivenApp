<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Survey.aspx.cs" Inherits="Survey" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
                <asp:Label ID="headerTitle_lbl" runat="server" Text="Take A Survey"></asp:Label>

    </div>
    <div>
        <asp:Label ID="questionText" runat="server" Text="Question - "></asp:Label>
        <asp:Label ID="questionNumber_lbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:PlaceHolder ID="surveySet_plc" runat="server"></asp:PlaceHolder>
    </div>
        

    <footer>
        <div>
            <asp:PlaceHolder ID="button_plc" runat="server"></asp:PlaceHolder>
        </div>
        <asp:Label ID="debug_lbl" runat="server" Text=""></asp:Label>
    </footer>
</asp:Content>


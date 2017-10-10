<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
                <asp:Label ID="headerTitle_lbl" runat="server" Text="Welcome to Ethical Surveys"></asp:Label>

    </div>

    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="Info" runat="server" Text="Please Choose From The Following"></asp:Label>        
        </div>
        <div class="col-md-4">
            <asp:Button ID="takeSurvey_btn" runat="server" Text="Take A Survey" class="btn btn-primary btn-lg myButton" OnClick="takeSurvey_btn_Click" />
        </div>
        <div class="col-md-4">
            <asp:Button ID="login_btn" runat="server" Text="Login" class="btn btn-primary btn-lg myButton"/>
        </div>
        <div class="col-md-4">
            <asp:Button ID="register_btn" runat="server" Text="Register" class="btn btn-primary btn-lg myButton" />
        </div>
        
    </div>
    <footer>
        <asp:Label ID="debug_lbl" runat="server" Text=""></asp:Label>
    </footer>
</asp:Content>

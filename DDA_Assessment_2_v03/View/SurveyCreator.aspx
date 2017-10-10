<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyCreator.aspx.cs" Inherits="View.SurveyCreator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Question"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="754px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Select the type of question"></asp:Label>
            <br />
            <asp:PlaceHolder ID="Question_Types_mc_sr" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>

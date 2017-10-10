<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_Page.aspx.cs" Inherits="View.Question_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="QuestionText_lbl" runat="server" Text="Question"></asp:Label>
        </div>
        <div>

            <asp:PlaceHolder ID="DynamicAnswerOptions_plc" runat="server"></asp:PlaceHolder>

        </div>
    </form>
</body>
</html>

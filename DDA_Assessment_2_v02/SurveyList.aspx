<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SurveyList.aspx.cs" Inherits="SurveyList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>

            <asp:Label ID="header_lbl" runat="server" Text="HEADER TEXT"></asp:Label>

        </header>
        <section>
            <div>
                <asp:Label ID="main_lbl" runat="server" Text="Please Select A Survey From The List"></asp:Label>
            </div>
            <div>

                <asp:PlaceHolder ID="tableOfSurveys" runat="server"></asp:PlaceHolder>
                <br />

                <br />
                <br />

            </div>
        </section>
        <footer>

        </footer>
    </div>
    </form>
</body>
</html>

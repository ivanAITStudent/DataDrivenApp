<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login_Page.aspx.cs" Inherits="Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header>

        </header>
        <section>
            <div>
                <asp:Label ID="main_lbl" runat="server" Text="Please Make A Select"></asp:Label>
            </div>
            <div>

                <asp:Button ID="takeSurvey_btn" runat="server" Text="Take A Survey" />
                <br />
                <asp:Button ID="login_btn" runat="server" Text="Login" Width="267px" />

                <br />
                <asp:Button ID="register_btn" runat="server" Text="Register" Width="266px" />
                <br />

            </div>
        </section>
        <footer>

        </footer>
    </div>
    </form>
</body>
</html>

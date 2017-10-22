<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestValidator.aspx.cs" Inherits="SQL_Conncetion.TestValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="NameTextBox" Display="Dynamic" 
        ErrorMessage="Name is required!"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="DOB"></asp:Label>
    <asp:TextBox ID="DOBTextBox" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="DOBTextBox" Display="Dynamic" 
        ErrorMessage="Date should be within range!" MaximumValue="03/23/2017" 
        MinimumValue="01/01/1869" Type="Date"></asp:RangeValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
    <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToValidate="AgeTextBox" Display="Dynamic" 
        ErrorMessage="You must be at least 18 years old!" Operator="GreaterThanEqual" 
        Type="Integer" ValueToCompare="18"></asp:CompareValidator>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="EmailTextBox" Display="Dynamic" 
        ErrorMessage="Not a valid email!" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        HeaderText="&lt;b&gt;Please review the following errors&lt;/b&gt;" />
    </form>
</body>
</html>

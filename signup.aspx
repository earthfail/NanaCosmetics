<%@ Page Language="C#" AutoEventWireup="true"   CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                    <asp:Label ID="taken" runat="server" ForeColor="Red" Text="*Email already taken*" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="password1" runat="server" TextMode="Password" ></asp:TextBox>
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged"/>
                    <asp:Label ID="Label7" runat="server" Text="show me password"></asp:Label>
      &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="confirm password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="password2" runat="server"  TextMode="Password"></asp:TextBox>
                    <asp:Label ID="alert" runat="server" Text="*password does not match*" Visible="False" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="birth day"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="birthday" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Have an account?"></asp:Label>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/signin.aspx">sign in</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="sign up" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

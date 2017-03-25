<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 100%;
            border-style: solid;
            border-width: 1px;
            text-transform:capitalize;
        }
        #singuplink, #singuplink:hover, #singuplink:visited {
            text-decoration: none;
            color: inherit;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="userEmailBox" runat="server" TextMode="Email"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordBox" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
        <asp:Label ID="Label3" runat="server" Text="email or password incorrect" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Button2" runat="server" Text="log in" OnClick="Button2_Click" />
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Don't have an account? "></asp:Label>
                    <asp:HyperLink ID="singuplink" runat="server" NavigateUrl="~/signup.aspx">Click Here</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

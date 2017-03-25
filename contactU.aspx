<%@ Page Title="" Language="C#" MasterPageFile="~/usersmp.master" AutoEventWireup="true" CodeFile="contactU.aspx.cs" Inherits="contactU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        body { 
  background: url("web_images/contactUV.png") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
        .auto-style3 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
        }
        .issue{
            /*some code to make it fixed in size*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   
    <table class="auto-style3">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="gratitude" runat="server" ForeColor="Red" Text="*thank you for your support*" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Message:"></asp:Label>
            </td>
            <td colspan="2" rowspan="2">
                <asp:TextBox ID="message" runat="server" TextMode="MultiLine" OnTextChanged="message_TextChanged" AutoPostBack="True" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="send" runat="server" Text="Send" Visible="False" OnClick="send_Click" />
            </td>
            <td>
                <asp:CheckBox ID="agree" runat="server"  Text="I agree on publishing some/all of the text"/>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
   
</asp:Content>


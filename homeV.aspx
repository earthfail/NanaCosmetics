<%@ Page Title="" Language="C#" MasterPageFile="~/visitorsmp.master" AutoEventWireup="true" CodeFile="homeV.aspx.cs" Inherits="homeV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       #logo { 
  background: url("web_images/homeV.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Table ID="calculator" runat="server" BorderColor="Black" BorderWidth="2px" GridLines="Both">
            <asp:TableHeaderRow><asp:TableHeaderCell ColumnSpan="4"><asp:Label ID="screen" runat="server" Text="0" Width="100px" Height="20px"></asp:Label></asp:TableHeaderCell></asp:TableHeaderRow>
            <asp:TableFooterRow>
                <asp:TableCell><asp:Button ID="one" runat="server" Text="1" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="two" runat="server" Text="2" OnClick="Button_Click" /></asp:TableCell>
               <asp:TableCell><asp:Button ID="three" runat="server" Text="3" OnClick="Button_Click" /></asp:TableCell>
               <asp:TableCell><asp:Button ID="plus" runat="server" Text="+" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableFooterRow>
             <asp:TableFooterRow>
                <asp:TableCell><asp:Button ID="four" runat="server" Text="4" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="five" runat="server" Text="5" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="six" runat="server" Text="6" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="minus" runat="server" Text="-" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableFooterRow>
             <asp:TableFooterRow>
                <asp:TableCell><asp:Button ID="seven" runat="server" Text="7" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="eight" runat="server" Text="8" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="nine" runat="server" Text="9" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="mult" runat="server" Text="*" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell><asp:Button ID="zero" runat="server" Text="0" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="open_bracket" runat="server" Text="(" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="close_bracket" runat="server" Text=")" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="div" runat="server" Text="/" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableFooterRow>
            <asp:TableFooterRow>
                <asp:TableCell ColumnSpan="3"><asp:Button ID="equal" runat="server" Text="=" OnClick="Button_Click" /></asp:TableCell>
                <asp:TableCell><asp:Button ID="erase" runat="server" Text="C" OnClick="Button_Click" /></asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
</asp:Content>


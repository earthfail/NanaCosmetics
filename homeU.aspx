<%@ Page Title="" Language="C#" MasterPageFile="~/usersmp.master" AutoEventWireup="true" CodeFile="homeU.aspx.cs" Inherits="homeU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       body { 
  background: url("web_images/homeU.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="X">X</asp:ListItem>
        <asp:ListItem Value="O">O</asp:ListItem>
    </asp:DropDownList> 
    <asp:Label ID="player" runat="server" Text="player" Visible="True"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PLAY" />
    <br />
     <asp:Button ID="l00" runat="server" Text=" " OnClick="check_list" Visible="False" />
    <asp:Button ID="l01" runat="server" Text=" " OnClick="check_list" Visible="False" />
    <asp:Button ID="l02" runat="server" Text=" " OnClick="check_list" Visible="False"/> <br />
    <asp:Button ID="l10" runat="server" Text=" " OnClick="check_list" Visible="False"/>
    <asp:Button ID="l11" runat="server" Text=" " OnClick="check_list" Visible="False"/>
    <asp:Button ID="l12" runat="server" Text=" " OnClick="check_list" Visible="False"/><br />
    <asp:Button ID="l20" runat="server" Text=" " OnClick="check_list" Visible="False"/>
    <asp:Button ID="l21" runat="server" Text=" " OnClick="check_list" Visible="False"/>
    <asp:Button ID="l22" runat="server" Text=" " OnClick="check_list" Visible="False"/>
    
    <br />
    <asp:Label ID="score" runat="server" Text=" " Visible="false"></asp:Label>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/visitorsmp.master" AutoEventWireup="true" CodeFile="contactV.aspx.cs" Inherits="contactV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
      #logo { 
  background: url("web_images/contactUV.png") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
        * {
        text-align:center;
        }
        #Phone:hover,#Facebook:hover,#Instagram:hover{
            text-transform:capitalize;
            text-shadow:-20px -5px 2px #333;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <div id="Phone" >Phone:079587864</div>
    <br />
    <div id="Facebook" >Facebook:Nana Cosmetics</div>
    <br />
    <div id="Instagram"  >Instagram:Nana Cosmetics</div>
  
</asp:Content>


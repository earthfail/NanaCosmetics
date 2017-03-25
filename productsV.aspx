<%@ Page Title="" Language="C#" MasterPageFile="~/visitorsmp.master" AutoEventWireup="true" CodeFile="productsV.aspx.cs" Inherits="productsV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #logo { 
  background: url("web_images/productsV.jpg") no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="category:">

    </asp:Label> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="AccessDataSource2" DataTextField="category" 
            DataValueField="category" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            style="text-align: center">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" 
            DataSourceID="AccessDataSource1" 
            
            style="text-align: center">
            <Columns>
                <asp:BoundField DataField="pname" HeaderText="productName" 
                    SortExpression="pname" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    
                <asp:TemplateField HeaderText="">
                <ItemTemplate>
                <asp:Image ID="Picture" runat="server" Width="200" Height="200" ImageUrl='<%#Eval("imagesrc") %>'/></ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/data/projectDB.accdb" 
            SelectCommand="SELECT [pname],[price],[imagesrc] FROM [productsTbl] WHERE [category] = c">
            <SelectParameters>
                <asp:SessionParameter  Name="category" 
                    SessionField="category" Type="String" />
            </SelectParameters>
        </asp:AccessDataSource>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
            DataFile="~/data/projectDB.accdb" 
            SelectCommand="SELECT DISTINCT [category] FROM [productsTbl]">
        </asp:AccessDataSource>
</asp:Content>


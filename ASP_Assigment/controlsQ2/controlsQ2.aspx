<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controlsQ2.aspx.cs" Inherits="validator.controlsQ2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 292px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>raddish</asp:ListItem>
            <asp:ListItem>mustard</asp:ListItem>
            <asp:ListItem>cauliflower</asp:ListItem>
        </asp:DropDownList>
        <asp:Image ID="Image1" runat="server" Height="165px" Width="125px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter" />
        
        <br />
        <br />
        <asp:Label ID="Price" runat="server" Text="Label"></asp:Label>
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_add.aspx.cs" Inherits="WebApplication1.admin.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table>
            <tr><td>Types Title: 
                <asp:TextBox ID="title" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>Types State: 
                <asp:DropDownList ID="state" runat="server">
                    <asp:ListItem Selected="True" Value="1">Open</asp:ListItem>
                    <asp:ListItem Value="0">Close</asp:ListItem>
                </asp:DropDownList>
                </td></tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
    </form>
</body>
</html>

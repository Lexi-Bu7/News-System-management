<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="menu_add.aspx.vb" Inherits="Website.menu_add" %>

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
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>Types State: 
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Selected="True" Value="1">Open</asp:ListItem>
                    <asp:ListItem Value="0">Close</asp:ListItem>
                </asp:DropDownList>
                </td></tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_4.aspx.cs" Inherits="Database._4_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 25px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>添加管理员</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">用户名：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>密码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>确认密码：<asp:TextBox ID="txtEPwd" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>类别：<asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem Value="0">一般管理员</asp:ListItem>
                        <asp:ListItem Value="1">超级管理员</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添加" />
                        <asp:Button ID="Button2" runat="server" Text="取消" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_5.aspx.cs" Inherits="Database._4_5" %>

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
            width: 252px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">根据指定列名读取指定用户的信息</td>
                <td rowspan="5">
                    <asp:Label ID="lblInfo" runat="server" Text="显示指定用户信息："></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">列名：<asp:DropDownList ID="ddlCols" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCols_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">数据项：<asp:ListBox ID="ltbItems" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ltbItems_SelectedIndexChanged"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>

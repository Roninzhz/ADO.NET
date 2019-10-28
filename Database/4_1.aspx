<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_1.aspx.cs" Inherits="Database._4_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="显示信息："></asp:Label>
            <br />
            <asp:Button ID="btnSM" runat="server" OnClick="btnSM_Click" Text="连接数据库" />
            <br />
            <asp:Button ID="CreateTable" runat="server" OnClick="CreateTable_Click" Text="创建Test表" />
            <br />
            <asp:Button ID="Count_Click" runat="server" OnClick="Count_Click_Click" Text="统计注册人数" />
        </div>
    </form>
</body>
</html>

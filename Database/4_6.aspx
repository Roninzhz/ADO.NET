<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_6.aspx.cs" Inherits="Database._4_6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblView" runat="server" Text="查看商品信息表中的数据"></asp:Label>
            <br />
            <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="查看" />
        </div>
    </form>
</body>
</html>

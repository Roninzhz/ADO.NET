<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_11.aspx.cs" Inherits="Database._4_11" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;
<p>
    使用存储过程，添加商品类别：</p>
<p>
    -------------------------------------------------</p>
<p>
    类别名称：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnAddType" runat="server" OnClick="btnAddType_Click" Text="添加" />
</p>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_9.aspx.cs" Inherits="Database._4_9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            使用数据源控件实现商品信息显示：</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="gdCode" HeaderText="gdCode" SortExpression="gdCode" />
                <asp:BoundField DataField="gdName" HeaderText="gdName" SortExpression="gdName" />
                <asp:BoundField DataField="gdPrice" HeaderText="gdPrice" SortExpression="gdPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SMDBConnectionString %>" SelectCommand="SELECT [gdCode], [gdName], [gdPrice] FROM [Goods]"></asp:SqlDataSource>
    </form>
</body>
</html>

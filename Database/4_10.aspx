<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_10.aspx.cs" Inherits="Database._4_10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            使用数据源控件实现商品的模糊查询<br />
            <asp:Button ID="btnSearch" runat="server" Text="查询" />
            <asp:TextBox ID="txtFind" runat="server"></asp:TextBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SMDBConnectionString %>" SelectCommand="SELECT * FROM [Goods] WHERE ([gdName] LIKE '%' + @gdName + '%')">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtFind" Name="gdName" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="gdID" DataSourceID="SqlDataSource1" EnableModelValidation="True" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="gdID" HeaderText="gdID" InsertVisible="False" ReadOnly="True" SortExpression="gdID" />
                    <asp:BoundField DataField="tID" HeaderText="tID" SortExpression="tID" />
                    <asp:BoundField DataField="gdCode" HeaderText="gdCode" SortExpression="gdCode" />
                    <asp:BoundField DataField="gdName" HeaderText="gdName" SortExpression="gdName" />
                    <asp:BoundField DataField="gdPrice" HeaderText="gdPrice" SortExpression="gdPrice" />
                    <asp:BoundField DataField="gdQuantity" HeaderText="gdQuantity" SortExpression="gdQuantity" />
                    <asp:BoundField DataField="gdSaleQty" HeaderText="gdSaleQty" SortExpression="gdSaleQty" />
                    <asp:BoundField DataField="gdFeight" HeaderText="gdFeight" SortExpression="gdFeight" />
                    <asp:BoundField DataField="gdCity" HeaderText="gdCity" SortExpression="gdCity" />
                    <asp:BoundField DataField="gdImage" HeaderText="gdImage" SortExpression="gdImage" />
                    <asp:BoundField DataField="gdInfo" HeaderText="gdInfo" SortExpression="gdInfo" />
                    <asp:BoundField DataField="gdAddTime" HeaderText="gdAddTime" SortExpression="gdAddTime" />
                    <asp:BoundField DataField="gdEvNum" HeaderText="gdEvNum" SortExpression="gdEvNum" />
                </Fields>
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>

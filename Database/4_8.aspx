<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_8.aspx.cs" Inherits="Database._4_8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            绑定集合数据<br />
            <asp:DropDownList ID="ddlGoodType" runat="server">
            </asp:DropDownList>
            <asp:CheckBoxList ID="chkGoodType" runat="server">
            </asp:CheckBoxList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="tID" DataSourceID="SqlDataSource1" EnableModelValidation="True" Width="318px">
                <Columns>
                    <asp:BoundField DataField="tID" HeaderText="tID" InsertVisible="False" ReadOnly="True" SortExpression="tID" />
                    <asp:BoundField DataField="tName" HeaderText="tName" SortExpression="tName" />
                    <asp:BoundField DataField="tImg" HeaderText="tImg" SortExpression="tImg" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SMDBConnectionString %>" SelectCommand="SELECT * FROM [GoodsType]"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>

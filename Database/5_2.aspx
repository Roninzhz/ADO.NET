<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5_2.aspx.cs" Inherits="Database._5_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gvGoodsType" runat="server" DataKeyNames="tID" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="tID" HeaderText="类别编号" />
                <asp:BoundField DataField="tName" HeaderText="类别名称" />
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="确认插入" />
        <br />
        填写要更新的数据：<asp:TextBox ID="txtNamebe" runat="server"></asp:TextBox>
        <br />
        更新后的数据：<asp:TextBox ID="txtNameaf" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="确认更新" />
        <br />
        填写你要删除的数据：<asp:TextBox ID="txtNameDe" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="确认删除" />
    </form>
</body>
</html>

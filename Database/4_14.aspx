﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_14.aspx.cs" Inherits="Database._4_14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{font-size:0.8em;}
        a{text-decoration:none;}
        .tb{width:200px;height:300px;}
        .tbrow{height:30px;vertical-align:top;text-align:center;}
        .tdr{width:80px;padding:5px;}
        .tdl{width:110px;padding:5px;}
        .img{width:200px;height:200px;border:0;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="dlstGoods" runat="server" RepeatColumns="3" DataSourceID="sqlGoods" DataKeyField="gdID">
                <ItemTemplate>
                    <table class="tb">
                        <tr>
                            <td colspan="2"><a href=""><asp:Image ID="Image1" runat="server" ToolTip='<%#Eval("gdName") %>' CssClass="img" ImageUrl='<%#Eval("gdImage","images/goods/{0}") %>' /></a></td>
                        </tr>
                        <tr><td>
                            <a href="">
                                <asp:Label ID="lbl1" runat="server" Text='<%#Eval("gdName") %>' />
                            </a>
                            </td></tr>
                        <tr><td class="tdl">价格：
                            <asp:Literal ID="lbl2" runat="server" Text='<%#Eval("gdPrice","{0:C}") %>' />
                            <td class="tdr">运费：
                            <asp:Literal ID="lt1" runat="server" Text='<%#Eval("gdFeight","{0:C}") %>' /></td>
                            </td></tr>
                        <tr><td class="tdl">已售：
                            <asp:Literal ID="lt2" runat="server" Text='<%#Eval("gdSaleQty","{0}件") %>' />
                            </td><td class="tdr">评价数：
                                 <asp:Literal ID="lt3" runat="server" Text='<%#Eval("gdEvNum") %>' />
                                 </td></tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="sqlGoods" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DataBase\SMDB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="select * from [Goods]" />
                </div>
    </form>
</body>
</html>
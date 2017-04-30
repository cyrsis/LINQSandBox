<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CommodityManagement.Web._Default" %>
<%@ Register Src="CommoditiesShow.ascx" TagName="CommoditiesShow" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>商品列表</title>
    <style type="text/css">
        body
        {
            margin: 0px;
        }
        .leftspace
        {
            text-indent: 12px;
        }
        A:link
        {
            color: #000099;
            text-decoration: none;
        }
        A:visited
        {
            color: #006699;
            text-decoration: none;
        }
        A:active
        {
            color: #006699;
            text-decoration: none;
        }
        A:hover
        {
            color: Red;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <asp:Label BackColor="#003399" ID="Label2" runat="server" Width="100%">
        <asp:Label ID="Label1" runat="server" Text="商品列表" Font-Bold="True" Font-Italic="True"
            Font-Size="XX-Large" ForeColor="White" Height="35px" CssClass="leftspace"></asp:Label>
    </asp:Label>
    <form id="form1" runat="server">
    <uc1:CommoditiesShow ID="CommoditiesShow" runat="server" />
    <asp:TextBox ID="pagenum" runat="server" Visible="False">1</asp:TextBox>
      <asp:Label ID="info" runat="server" style="font-size: 12px" class="leftspace"></asp:Label>
    <asp:Panel style="font-size: 12px" CssClass="leftspace" ID="nav" runat="server">
        <asp:LinkButton ID="fistbut" runat="server" OnClick="fistbut_Click">[首页]</asp:LinkButton>
        <asp:LinkButton ID="prebut" runat="server" OnClick="prebut_Click">[前页]</asp:LinkButton>
        <asp:LinkButton ID="nextbut" runat="server" OnClick="nextbut_Click">[后页]</asp:LinkButton>
        <asp:LinkButton ID="lastbut" runat="server" OnClick="lastbut_Click">[末页]</asp:LinkButton>　 每页显示的记录数：
        <asp:TextBox ID="pagerow" runat="server" Width="20px">1</asp:TextBox>
    </asp:Panel>
    
    <br />
    <br />
    <br />
    <div style="font-size: 12px" class="leftspace" >
    输入搜索关键字：<asp:TextBox ID="seckey" runat="server" Width="200px"></asp:TextBox>
    <asp:Button ID="secbut" runat="server" Text="搜索" onclick="secbut_Click" />
    </div>
    </form>
</body>
</html>

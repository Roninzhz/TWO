<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WCount.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            会员登录</p>
        <p>
            用户名：<asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
        </p>
        <p>
            密码：&nbsp; 
            <asp:TextBox ID="txtUPwd" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkState" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="两周内不登录" />
        </p>
        <p>
            <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="确定" />
            <asp:Button ID="Button2" runat="server" Text="取消" />
        </p>
    </form>
</body>
</html>

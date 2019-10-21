<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_7.aspx.cs" Inherits="WCount._3_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            读文件示例：<br />
            <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="读文件" />
            <br />
            <asp:Label ID="lblInfo" runat="server" Text="文件内容："></asp:Label>
            <br />
            <asp:Button ID="btnWrite" runat="server" OnClick="btnWrite_Click" Text="写文件" />
        </div>
    </form>
</body>
</html>

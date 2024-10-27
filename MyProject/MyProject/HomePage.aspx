<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MyProject.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Button" />
        <p>
            <asp:Label ID="lblEventName" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

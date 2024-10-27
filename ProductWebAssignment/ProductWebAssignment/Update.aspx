<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="ProductWebAssignment.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server" draggable="true">
        <div class="col-12 pb-20">
            <asp:Label
                ID="lblMsg"
                runat="server"
                Text="Label"
                Visible="false"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Product Id"></asp:Label>
            &nbsp;<br />
            <br />
            <asp:TextBox ID="txtId" runat="server" Height="28px" Width="290px" Style="margin-left: 0px"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" BackColor="#FF6699" OnClick="btnSearch_Click" Text="Button" />
            <br />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
            &nbsp;<br />
            <br />
            <asp:TextBox ID="txtProductName" runat="server" Height="28px" Width="285px" Style="margin-left: 0px"></asp:TextBox>
            <br />
        </div>

        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtPrice" runat="server" Height="28px" Style="margin-left: 0px" Width="281px"></asp:TextBox>
            <br />
        </div>

        <div>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtQuantity"  TextMode="Number" runat="server" Height="28px" Style="margin-left: 0px" Width="276px"></asp:TextBox>
        </div>


        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Height="27px" OnClick="btnUpdate_Click" Style="margin-left: 6px" Text="Update" Width="77px" BackColor="#FFFF99" />
        &nbsp;&nbsp;
    
        &nbsp;
    <asp:Button ID="btnCancel" runat="server" Height="28px" OnClick="btnCancel_Click" Style="margin-left: 6px" Text="Cancel" Width="69px" BackColor="#CC0000" />

        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBack" runat="server" BackColor="#66CCFF" OnClick="btnBack_Click" Text="Back" />

        <br />
        &nbsp;<br />


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Product_Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="233px" Width="484px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" InsertVisible="False" ReadOnly="True" SortExpression="Product_Id" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductDBConnectionString %>" SelectCommand="SELECT [Product_Id], [ProductName], [Price], [Quantity] FROM [Product]"></asp:SqlDataSource>

    </form>

</body>
</html>

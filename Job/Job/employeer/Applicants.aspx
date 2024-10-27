<%@ Page Title="" Language="C#" MasterPageFile="~/employeer/Employee.master" AutoEventWireup="true" CodeFile="Applicants.aspx.cs" Inherits="employeer_Applicants" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="my_copmanyid" runat="server" Visible="False"></asp:TextBox>
    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="spjobandseekerrelation" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="my_copmanyid" Name="companyid" PropertyName="Text" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" Width="100%">
        <Columns>
            <asp:BoundField DataField="Jobs_Title" HeaderText="Jobs Title" SortExpression="Jobs_Title">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="First_name" HeaderText="Applicants Name" SortExpression="First_name">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Mobile" HeaderText="Contact No" SortExpression="Mobile">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Details">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" ImageHeight="30px" ImageUrl="~/images/Details.png" ImageWidth="50px">HyperLink</asp:HyperLink>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <br />

</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" BackColor="White"  GridLines="None"  Width="98%" >
        <Columns>
            <asp:BoundField DataField="Jobs_Title" HeaderText="Title" SortExpression="Jobs_Title" >
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle CssClass="gridview_jobs_row" />
            </asp:BoundField>
            <asp:BoundField DataField="Vacancy" HeaderText="Vacancy" SortExpression="Vacancy" >
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" CssClass="gridview_jobs_row" />
            </asp:BoundField>
            <asp:BoundField DataField="Jobs_Location" HeaderText="Location" SortExpression="Jobs_Location" >
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle CssClass="gridview_jobs_row" />
            </asp:BoundField>
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" >
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle CssClass="gridview_jobs_row" />
            </asp:BoundField>
            <asp:BoundField DataField="Jobs_deadline" HeaderText="Deadline" SortExpression="Jobs_deadline">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle CssClass="gridview_jobs_row" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Details">
                <ItemTemplate>
                    <asp:HyperLink ID="hp_details" NavigateUrl='<%#DataBinder.Eval(Container.DataItem,"id","~/Jobdetails.aspx?i_d={0}") %>' runat="server" Font-Bold="True" Text="Details" Font-Underline="False"></asp:HyperLink>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" CssClass="gridview_jobs_row" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White"  ForeColor="Black" CssClass="gridview_jobs_rowfull" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <br />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [id], [Jobs_Title], [Vacancy], [Jobs_Location], [Salary], [Jobs_deadline] FROM [View_Jobs]"></asp:SqlDataSource>
</asp:Content>


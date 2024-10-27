<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Jobdetails.aspx.cs" Inherits="Jobdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {}
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" GridLines="None" DataKeyNames="id" DataSourceID="SqlDataSource2" CssClass="auto-style1" ShowHeader="False" Width="166px">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="hp_apply" runat="server" ImageUrl="~/images/applybtn.png"  ImageWidth="184px" NavigateUrl='<%# "MyProfile.aspx?i_d=" + Eval("id") + "&job_title=" + Server.UrlEncode(Eval("Jobs_Title").ToString()) %>' >Apply Now</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [id], [Jobs_Title] FROM [View_Jobs] WHERE ([id] = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="i_d" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" GridLines="None" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" CellPadding="10" CellSpacing="2"  DataSourceID="SqlDataSource1" Height="50px" Width="272px">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="Jobs_Title" HeaderText="Title" SortExpression="Jobs_Title" />
            <asp:BoundField DataField="Jobs_catagory" HeaderText="Catagory" SortExpression="Jobs_catagory" />
            <asp:BoundField DataField="Vacancy" HeaderText="No Of Vacancy" SortExpression="Vacancy" />
            <asp:BoundField DataField="Discription" HeaderText="Discription" SortExpression="Discription" />
            <asp:BoundField DataField="Jobs_Nature" HeaderText="Jobs Nature" SortExpression="Jobs_Nature" />
            <asp:BoundField DataField="Educational_req" HeaderText="Educational Requirements" SortExpression="Educational_req" />
            <asp:BoundField DataField="Jobs_Location" HeaderText="Jobs Location" SortExpression="Jobs_Location" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            <asp:BoundField DataField="Jobs_deadline" HeaderText="Application Deadline" SortExpression="Jobs_deadline" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle  BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [Jobs_Title], [Jobs_catagory], [Vacancy], [Discription], [Jobs_Nature], [Educational_req], [Jobs_Location], [Salary], [Jobs_deadline] FROM [View_Jobs] WHERE ([id] = @id)">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="i_d" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/employeer/Employee.master" AutoEventWireup="true" CodeFile="MyJobs.aspx.cs" Inherits="employeer_MyJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .my {
    overflow:auto;
}

</style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="spviewjobs" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:ControlParameter ControlID="TextBox1" Name="user_name" PropertyName="Text" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" Width="100%">
        <Columns>
            <asp:BoundField DataField="Jobs_Title" HeaderText="Jobs_Title" SortExpression="Jobs_Title" />
            <asp:BoundField DataField="Jobs_catagory" HeaderText="Jobs_catagory" SortExpression="Jobs_catagory" />
            <asp:BoundField DataField="Vacancy" HeaderText="Vacancy" SortExpression="Vacancy" />
            <asp:BoundField DataField="Discription" HeaderText="Discription" SortExpression="Discription" />
            <asp:BoundField DataField="Jobs_Nature" HeaderText="Jobs_Nature" SortExpression="Jobs_Nature" />
            <asp:BoundField DataField="Educational_req" HeaderText="Educational_req" SortExpression="Educational_req" />
            <asp:BoundField DataField="Jobs_Location" HeaderText="Jobs_Location" SortExpression="Jobs_Location" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            <asp:BoundField DataField="Jobs_deadline" HeaderText="Jobs_deadline" SortExpression="Jobs_deadline" />
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
<asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
    <div class="my">
<asp:GridView ID="GridView1" runat="server" style="overflow:auto" RowStyle-Wrap="false" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" CellPadding="4" DataSourceID="SqlDataSource1">
    <AlternatingRowStyle Width="100%" />
    <Columns>
        <asp:BoundField DataField="Jobs_Title" HeaderText="Jobs Title" SortExpression="Jobs_Title" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Jobs_catagory" HeaderText="Catagory" SortExpression="Jobs_catagory" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Vacancy" HeaderText="Vacancy" SortExpression="Vacancy" >
        <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Discription" HeaderText="Discription" SortExpression="Discription" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Jobs_Nature" HeaderText="Jobs Nature" SortExpression="Jobs_Nature" >
        <HeaderStyle HorizontalAlign="Center" />
        <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Educational_req" HeaderText="Educational Requirements" SortExpression="Educational_req" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Jobs_Location" HeaderText="Jobs Location" SortExpression="Jobs_Location" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" >
        <HeaderStyle HorizontalAlign="Center" />
        <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Jobs_deadline" HeaderText="Jobs Deadline" SortExpression="Jobs_deadline" >
        <HeaderStyle HorizontalAlign="Center" />
        <ItemStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:TemplateField HeaderText="Edit">
            <ItemTemplate>
                <asp:ImageButton ID="btn_edit_myjobs" runat="server" ImageUrl="~/images/edit.png" PostBackUrl='<%# "EditJobs.aspx?id=" + Eval("id") %>' />
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:ImageButton ID="btn_delte_myjobs" runat="server" ImageUrl="~/images/delte.png" OnClick="btn_delte_myjobs_Click" />
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#330099"  />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <SortedAscendingCellStyle BackColor="#FEFCEB" />
    <SortedAscendingHeaderStyle BackColor="#AF0101" />
    <SortedDescendingCellStyle BackColor="#F6F0C0" />
    <SortedDescendingHeaderStyle BackColor="#7E0000" />
</asp:GridView>
     </div>
</asp:Content>


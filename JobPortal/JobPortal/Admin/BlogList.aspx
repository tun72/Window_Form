<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BlogList.aspx.cs" Inherits="JobPortal.Admin.BlogList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover" class="mb-10">

        <div class="container pt-4 pb-4">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

        <div class="input-group ml-70">
            <asp:HyperLink ID="linkBack" runat="server" Visible="false" NavigateUrl="~/Admin/ViewBlogs.aspx" CssClass=" text-primary">< Back</asp:HyperLink>
        </div>

        <h3 class="text-center mb-3">Blog List</h3>

        <div class="row mr-lg-5 ml-lg-5">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="GridView1" CssClass="table table-hover table-bordered" OnRowDataBound="GridView1_RowDataBound" EmptyDataText="No record to display..!" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="5" DataKeyNames="BlogId" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="SrNo" HeaderText="Sr.No">
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="Title" HeaderText="Blog Title">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="CategoryName" HeaderText="Category">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="PublishedDate" HeaderText="Published Date" DataFormatString="{0:dd MMMM yyyy}">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnEditBlog" runat="server" CommandName="EditBlog" CommandArgument='<%# Eval("BlogId") %>'>
                                    <asp:Image ID="Img" runat="Server" ImageUrl="../assets/img/icon/editIcon.png" Height="25px" />
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>

                        <asp:CommandField CausesValidation="false" HeaderText="Delete" ShowDeleteButton="true" DeleteImageUrl="../assets/img/icon/trashIcon.png" ButtonType="Image">
                            <ControlStyle Height="25px" Width="25px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>
                    </Columns>
                    <HeaderStyle BackColor="#7200cf" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

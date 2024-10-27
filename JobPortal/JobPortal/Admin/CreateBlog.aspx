<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CreateBlog.aspx.cs" Inherits="JobPortal.Admin.CreateBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat;" class="mb-10">
            <div class="container pt-4 pb-4">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>

            <div class="input-group">
                <asp:HyperLink ID="linkBtnBack" runat="server" NavigateUrl="~/Employee/BlogList.aspx" CssClass="btn btn-secondary" Visible="false"> < Back</asp:HyperLink>
            </div>

            <h3 class="text-center"><% Response.Write(Session["title"]); %></h3>

            <div>
                <form id="blogCreateForm" class="mt-4 mx-auto bg-success" method="post">
                    <!-- Blog Title -->
                    <div class="form-group">
                        <label for="blogTitle">Blog Title</label>
                        <asp:TextBox ID="txtBlogTitle" CssClass="form-control w-100" runat="server" placeholder="Enter blog title"></asp:TextBox>
                    </div>

                    <!-- Blog Content -->
                    <div class="form-group">
                        <label for="blogContent">Content</label>
                        <asp:TextBox ID="txtBlogContent" TextMode="MultiLine" Rows="5" CssClass="form-control  w-100" runat="server" placeholder="Enter blog content"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="blogContent">Image</label>
                        <asp:TextBox ID="txtImageUrl" TextMode="Url" Rows="5" CssClass="form-control  w-100" runat="server" placeholder="Enter blog image"></asp:TextBox>
                    </div>

                    <!-- Blog Category -->
                    <div class="form-group">
                        <label for="blogCategory">Category</label>
                        <asp:DropDownList ID="ddlCategory" CssClass="form-control  w-100" runat="server">
                            <asp:ListItem Text="Select a category" Value="" />
                            <asp:ListItem Text="Technology" Value="Technology" />
                            <asp:ListItem Text="Lifestyle" Value="Lifestyle" />
                            <asp:ListItem Text="Education" Value="Education" />
                        </asp:DropDownList>
                    </div>

                    <!-- Submit Button -->
                    <div class="form-group">
                        <asp:Button ID="createBtn" runat="server" Text="Create" OnClick="createBtn_Click" CssClass="btn btn-primary" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

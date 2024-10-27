<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="JobPortal.User.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../assets/css/blog.css" />

    <div class="slider-area mb-100">
        <div class="single-slider section-overly slider-height2 d-flex align-items-center" data-background="../assets/img/hero/about.jpg">
            <div class="container">
                <div class="row">
                    <div class="col-xl-12">
                        <div class="hero-cap text-center">
                            <h2>Blogs & Tricks</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <!-- Cards -->
    <div class=" fix   blog mb-120">
        <div class="container">

            <asp:Repeater ID="dlBlog" runat="server">

                <HeaderTemplate>
                    <div class="row">
                </HeaderTemplate>
                <ItemTemplate>

                    <div class="col-md-3 col-sm-6 item">
                        <div class="card item-card card-block">
                            <img
                                src="<%# Eval("imageUrl") %>"
                                alt="Photo of sunset"  />


                            <div class="card-badge"><span class="badge badge-info block "><%# Eval("Category") %></span></div>

                            <a href="/User/BlogDetail.aspx?BlogId=<%# Eval("BlogId") %>">
                                <h5 class="item-card-title mt-3 mb-3"><%# Eval("Title") %></h5>
                            </a>
                            <p class="card-text mb-2">
                                <%# Eval("Content") %>
                            </p>

                        </div>
                    </div>

                </ItemTemplate>
                <FooterTemplate>
                    </div>
                </FooterTemplate>
            </asp:Repeater>



        </div>
    </div>
    </div>
</asp:Content>

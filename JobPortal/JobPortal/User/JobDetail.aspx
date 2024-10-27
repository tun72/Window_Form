﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="JobDetail.aspx.cs" Inherits="JobPortal.User.JobDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>

        <!-- Hero Area Start-->
        <div class="slider-area ">
            <div class="single-slider section-overly slider-height2 d-flex align-items-center" data-background="../assets/img/hero/about.jpg">
                <div class="container">
                    <div class="row">
                        <div class="col-xl-12">
                            <div class="hero-cap text-center">
                                <h2><%# jobTitle %></h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Hero Area End -->

        <div>
            <asp:Label ID="lblMsg" runat="server" Visible="false"></asp:Label>
        </div>
        <!-- job post company Start -->
        <div class="job-post-company pt-120 mb-50">
            <div class="container">
                <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound" CssClass="w-100">
                    <ItemTemplate>
                        <div class="row justify-content-between">
                            <!-- Left Content -->
                            <div class="col-xl-7 col-lg-8">
                                <!-- job single -->
                                <div class="single-job-items mb-50">
                                    <div class="job-items">
                                        <div class="company-img company-img-details">
                                            <a href="#">
                                                <img width="80" src="<%# GetImageUrl(Eval("CompanyImage")) %>" alt=""></a>
                                        </div>
                                        <div class="job-tittle">
                                            <a href="#">
                                                <h4><%# Eval("Title") %></h4>
                                            </a>
                                            <ul>
                                                <li><%# Eval("CompanyName") %></li>
                                                <li><i class="fas fa-map-marker-alt"></i><%# Eval("State") %>, <%# Eval("Country") %></li>
                                                <li><%# Eval("Salary") %></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <!-- job single End -->

                                <div class="job-post-details">
                                    <div class="post-details1 mb-50">
                                        <!-- Small Section Tittle -->
                                        <div class="small-section-tittle">
                                            <h4>Job Description</h4>
                                        </div>
                                        <p><%# Eval("Description") %></p>
                                    </div>
                                    <div class="post-details2  mb-50">
                                        <!-- Small Section Tittle -->
                                        <div class="small-section-tittle">
                                            <h4>Required Knowledge, Skills, and Abilities</h4>
                                        </div>
                                        <ul>
                                            <li><%# Eval("Specilization") %></li>
                                            <%--  <li>Mobile Applicationin iOS/Android/Tizen or other platform</li>
                                            <li>Research and code , libraries, APIs and frameworks</li>
                                            <li>Strong knowledge on software development life cycle</li>
                                            <li>Strong problem solving and debugging skills</li>--%>
                                        </ul>
                                    </div>
                                    <div class="post-details2  mb-50">
                                        <!-- Small Section Tittle -->
                                        <div class="small-section-tittle">
                                            <h4>Education + Experience</h4>
                                        </div>
                                        <ul>
                                            <li><%# Eval("Qulification") %></li>
                                            <li><%# Eval("Experience") %></li>
                                            <%--<li>Direct response email experience</li>
                                            <li>Ecommerce website design experience</li>
                                            <li>Familiarity with mobile and web apps preferred</li>
                                            <li>Experience using Invision a plus</li>--%>
                                        </ul>
                                    </div>
                                </div>

                            </div>
                            <!-- Right Content -->
                            <div class="col-xl-4 col-lg-4">
                                <div class="post-details3  mb-50">
                                    <!-- Small Section Tittle -->
                                    <div class="small-section-tittle">
                                        <h4>Job Overview</h4>
                                    </div>
                                    <ul>
                                        <li>Posted date : <span><%# DataBinder.Eval(Container.DataItem, "CreateDate", "{0:dd MMMM yyyy}") %></span></li>
                                        <li>Category : <span><%# Eval("Name") %></span></li>
                                        <li>Location : <span><%# Eval("State") %></span></li>
                                        <li>Vacancy : <span><%# Eval("NoOfPost") %></span></li>
                                        <li>Job nature : <span><%# Eval("JobType") %></span></li>
                                        <li>Salary :  <span><%# Eval("Salary") %></span></li>
                                        <li>Application date : <span><%# DataBinder.Eval(Container.DataItem, "LastDateToApply", "{0:dd MMMM yyyy}") %></span></li>
                                    </ul>
                                    <div class="apply-btn2">
                                        <asp:LinkButton ID="ApplyJob" runat="server" CssClass="btn" Text="Apply Now" CommandName="ApplyJob"></asp:LinkButton>

                                    </div>
                                </div>
                                <div class="post-details4  mb-50">
                                    <!-- Small Section Tittle -->
                                    <div class="small-section-tittle">
                                        <h4>Company Information</h4>
                                    </div>
                                    <span><%# Eval("CompanyName") %></span>
                                    <p>Address: <%# Eval("CompanyAddress") %></p>
                                    <ul>
                                        <li>Name: <span><%# Eval("CompanyName") %> </span></li>
                                        <li>Web : <span><%# Eval("website") %></span></li>
                                        <li>Email: <span><%# Eval("Email") %></span></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>

            </div>
        </div>

        <div class="related-job-post pt-120 pb-120 cursor-pointer">
            <div class="container">
                <div class="row">
                    <div class="col-xl-12">
                        <div class="section-tittle text-center">
                            <h2>Related Jobs</h2>
                        </div>
                    </div>
                </div>
                <asp:Repeater ID="dlRelatedJobs" runat="server">
                    <HeaderTemplate>
                        <div class="row justify-content-between">
                    </HeaderTemplate>
                    <ItemTemplate>

                        <div class="single-job-items mb-50 w-100 col-12 shadow-lg">
                            <div class="job-items">
                                <div class="company-img">
                                    <a href="#">
                                        <img width="80" src="<%# GetImageUrl(Eval("CompanyImage")) %>" alt="">
                                    </a>
                                </div>
                                <div class="job-tittle">
                                    <a href="JobDetail?Id=<%# Eval("JobId") %>">
                                        <h4><%# Eval("Title") %></h4>
                                    </a>
                                    <ul>
                                        <li><%# Eval("CompanyName") %></li>
                                        <li><i class="fas fa-map-marker-alt"></i><%# Eval("State") %>, <%# Eval("Country") %></li>
                                        <li><%# Eval("Salary") %></li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                    <FooterTemplate></div></FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!-- job post company End -->


        <!-- Related Jobs Start -->

        <!-- Related Jobs End -->


    </main>
</asp:Content>

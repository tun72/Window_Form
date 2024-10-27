<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="ViewResumes.aspx.cs" Inherits="JobPortal.Employee.ViewResumes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover" class="mb-10">

        <div class="container pt-4 pb-4">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

        <div class="input-group ml-70">

            <asp:HyperLink ID="linkBack" runat="server" Visible="false" NavigateUrl="~/Admin/ViewResumes.aspx" CssClass=" text-primary">< Back</asp:HyperLink>
        </div>

        <h3 class="text-center  mb-3">View All Resumes</h3>





        <asp:Repeater ID="JobLooper" runat="server">
            <HeaderTemplate>
                <div class="container mt-5 d-flex align-items-center flex-wrap">
            </HeaderTemplate>
            <ItemTemplate>

                <div class="card" style="width: 18rem;">
                    <div class="card-body text-center">
                        
                        
                        <h5 class="card-title mt-2"><%# Eval("Title") %></h5>

                        <p class="card-text"><small class="text-muted">(<%# Eval("NumberOfApplications") %>)</small></p>
                        <a href="ViewResumeDetail.aspx?JobId=<%# Eval("JobId") %>" class="text-primary">View</a>
                    </div>
                </div>


            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

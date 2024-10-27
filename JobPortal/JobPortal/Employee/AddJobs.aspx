<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/EmployeeMaster.Master" AutoEventWireup="true" CodeBehind="AddJobs.aspx.cs" Inherits="JobPortal.Employee.AddJobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat;" class="mb-10">
     <div class="container pt-4 pb-4">
         <asp:Label ID="lblMsg" runat="server"></asp:Label>
     </div>

     <div class="input-group">

         <asp:HyperLink ID="linkBtnBack" runat="server" NavigateUrl="~/Employee/JobList.aspx" CssClass="btn btn-secondary" Visible="false"> < Back</asp:HyperLink>
     </div>

     <h3 class="text-center"><%Response.Write(Session["title"]); %></h3>
     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-6 pt-3">
             <label for="txtJobTitle" style="font-weight: 600">Job Title</label>
             <asp:TextBox ID="txtJobTitle" runat="server" CssClass="form-control w-100" placeholder="Ex. Web Developer, App Developer"></asp:TextBox>
         </div>
         <div class="col-md-6 pt-3">
             <label for="txtNoPost" style="font-weight: 600">Number of Position</label>
             <asp:TextBox ID="txtNoPost" runat="server" CssClass="form-control w-100" placeholder="Enter Number of Position" TextMode="Number"></asp:TextBox>
         </div>
     </div>

     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-12 pt-3">
             <label for="txtDescription" style="font-weight: 600">Description</label>
             <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control w-100" placeholder="Enter Job Description" TextMode="MultiLine"></asp:TextBox>
         </div>
     </div>

     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-6 pt-3">
             <label for="txtQualification" style="font-weight: 600">Qulification/Education Required</label>
             <asp:TextBox ID="txtQualification" runat="server" CssClass="form-control w-100" placeholder="Ex. MCA, BText, MBA"></asp:TextBox>
         </div>
         <div class="col-md-6 pt-3">
             <label for="txtExperience" style="font-weight: 600">Experience Required</label>
             <asp:TextBox ID="txtExperience" runat="server" CssClass="form-control w-100" placeholder="Ex: 2 Years, 1.5 Years"></asp:TextBox>
         </div>
     </div>

     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-6 pt-3">
             <label for="txtSpecialization" style="font-weight: 600">Specialization Required</label>
             <asp:TextBox ID="txtSpecialization" runat="server" CssClass="form-control w-100" placeholder="Enter Specialization" TextMode="MultiLine"></asp:TextBox>
         </div>
         <div class="col-md-6 pt-3">
             <label for="txtLastDate" style="font-weight: 600">Last Date To Apply</label>
             <asp:TextBox ID="txtLastDate" runat="server" CssClass="form-control w-100" placeholder="Enter Last Date To Apply" TextMode="Date"></asp:TextBox>
         </div>
     </div>


     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-6 pt-3">
             <label for="txtSalary" style="font-weight: 600">Salary</label>
             <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control w-100" placeholder="Ex: 200000/Month, 7L/Year" TextMode="MultiLine"></asp:TextBox>
         </div>
         <div class="col-md-6 pt-3">
             <label for="ddlJobType" style="font-weight: 600">Job Types</label>
             <asp:DropDownList ID="ddlJobType" runat="server" CssClass="form-control w-100">
                 <asp:ListItem Value="0">Select Job Type</asp:ListItem>
                 <asp:ListItem Value="Full Time">Full Time</asp:ListItem>
                 <asp:ListItem Value="Part Time">Part Time</asp:ListItem>
                 <asp:ListItem Value="Freelance">Freelance</asp:ListItem>
                 <asp:ListItem Value="Remote">Remote</asp:ListItem>
             </asp:DropDownList>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Job Type is Required" ForeColor="Red" ControlToValidate="ddlJobType" InitialValue="0" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>

         </div>
     </div>

  

     


     <div class="row mr-lg-5 ml-lg-5 mb-3">
        
         <div class="col-md-6 pt-3">
             <label for="txtWebsite" style="font-weight: 600">Website</label>
             <asp:TextBox ID="txtWebsite" runat="server" CssClass="form-control w-100" placeholder="Enter Company/Organization Wedsite" TextMode="Url"></asp:TextBox>

         </div>

         <div class="col-md-6 pt-3">
             <label for="txtCountry" style="font-weight: 600">Category</label>

             <asp:DropDownList
                 ID="ddlCategory"
                 runat="server"
                 DataSourceID="SqlDataSource2"
                 CssClass="form-control w-100"
                 AppendDataBoundItem="true"
                 DataTextField="Name"
                 DataValueField="CategoryId">
                 <asp:ListItem Value="0">Select Category</asp:ListItem>
             </asp:DropDownList>
             <asp:RequiredFieldValidator
                 ID="RequiredFieldValidator3"
                 runat="server"
                 ErrorMessage="Category is required"
                 ControlToValidate="ddlCategory"></asp:RequiredFieldValidator>
             <asp:SqlDataSource
                 ID="SqlDataSource2"
                 runat="server"
                 ConnectionString="<%$ ConnectionStrings:cs %>"
                 SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
         </div>

     </div>

     <div class="row mr-lg-5 ml-lg-5 mb-3">
         <div class="col-md-6 pt-3">
             <label for="txtCountry" style="font-weight: 600">Country</label>

             <asp:DropDownList
                 ID="ddlCountry"
                 runat="server"
                 DataSourceID="SqlDataSource1"
                 CssClass="form-control w-100"
                 AppendDataBoundItem="true"
                 DataTextField="CountryName"
                 DataValueField="CountryName">
                 <asp:ListItem Value="0">Select Country</asp:ListItem>
             </asp:DropDownList>
             <asp:RequiredFieldValidator
                 ID="RequiredFieldValidator2"
                 runat="server"
                 ErrorMessage="Country is required"
                 ControlToValidate="ddlCountry"></asp:RequiredFieldValidator>
             <asp:SqlDataSource
                 ID="SqlDataSource1"
                 runat="server"
                 ConnectionString="<%$ ConnectionStrings:cs %>"
                 SelectCommand="SELECT [CountryName] FROM [Country]"></asp:SqlDataSource>
         </div>
         <div class="col-md-6 pt-3">
             <label for="txtState" style="font-weight: 600">State</label>
             <asp:TextBox ID="txtState" runat="server" CssClass="form-control w-100" placeholder="Enter State"></asp:TextBox>
         </div>


     </div>
     <div class="row mr-lg-5 ml-lg-5 pt-3 ">
         <div class="col-md-3 col-md-offset-2 mb-5">


             <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary btn-block" BackColor="#7200cf" Text="Add Job" OnClick="btnAdd_Click" />
         </div>
     </div>



 </div>
</asp:Content>

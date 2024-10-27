<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="ResumeBuild.aspx.cs" Inherits="JobPortal.User.ResumeBuild" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="mt-20">
        <div class="container">
            <div class="row">
                <div class="col-12 pb-20 d-flex flex-column align-items-start">
                    <asp:Label
                        ID="lblMsg"
                        runat="server"
                        Text="Label"
                        Visible="false"></asp:Label>
                    <a Class="btn btn-info d-block" href="/User/Profile.aspx"> < Back</a>
                </div>


               
                 
                <div class="col-lg-12">
                    <div
                        class="form-contact contact_form"
                        action="contact_process.php"
                        method="post"
                        id="contactForm">
                        <div class="row">
                            <div class="col-12 mb-3">
                                <h5 class="font-weight-bold">Update Information</h5>
                            </div>
                            <div class="col-sm-12 col-md-6">
                                <label>Username</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtUsername"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Username'"
                                        placeholder="Username"
                                        required></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 col-md-6">
                                 <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtEmail"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Email'"
                                        placeholder="Email"
                                        required></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 col-md-6">
                                 <label>FullName</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtFullName"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your FullName'"
                                        placeholder="FullName"
                                        required></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small" ValidationExpression="^[a-zA-z\s]+$" ControlToValidate="txtFullName" runat="server" ErrorMessage="Name must be in character"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-6">
                                <label>Address</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtAddress"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Address'"
                                        placeholder="Address"
                                        required></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 col-md-6">
                                <label>Phone</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPhone"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Phone Number'"
                                        placeholder="Phone"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 col-md-6">
                                <label>Country</label>
                                <div class="form-group">
                                    <asp:DropDownList
                                        ID="ddlCountry"
                                        runat="server"
                                        DataSourceID="SqlDataSource1"
                                        CssClass="w-100"
                                        AppendDataBoundItem="true"
                                        DataTextField="CountryName"
                                        DataValueField="CountryName">
                                        <asp:ListItem Value="0">Select Country</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator1"
                                        runat="server"
                                        ErrorMessage="Country is required"
                                        ControlToValidate="ddlCountry"></asp:RequiredFieldValidator>
                                    <asp:SqlDataSource
                                        ID="SqlDataSource1"
                                        runat="server"
                                        ConnectionString="<%$ ConnectionStrings:cs %>"
                                        SelectCommand="SELECT [CountryName] FROM [Country]"></asp:SqlDataSource>
                                </div>
                            </div>




                            <div class="col-12 mb-3 pt-4">
                                <h5 class="h5 font-weight-bold">Education/Resume Information</h5>
                            </div>

                            <div class="col-md-6 col-sm-12">
                                <label>10th Percentage/Grade</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtTenth"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Ex: 90%"
                                        ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6 col-sm-12">
                                <label>12th Percentage/Grade</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtTwelfth"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Ex: 90%"
                                        ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6 col-sm-12">
                                <label>Graduation with Pointer/Grade</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtGraduation"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Ex: Btech with 9.2 pointer"
                                       ></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-6 col-sm-12">
                                <label>Post Graduation</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPostGraduation"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Post Graduation"
                                        ></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-6 col-sm-12">
                                <label>PHD with Pointer/Grade</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPhd"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Phd with grade"
                                        ></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-6 col-sm-12">
                                <label>Job Profile/Works On</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtWork"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Job Profile"
                                        ></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-6 col-sm-12">
                                <label>Work Experience</label>
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtExperience"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder="Work Experience"
                                        ></asp:TextBox>
                                </div>
                            </div>


                            <div class="col-md-6 col-sm-12">
                                <label>Resume</label>
                                <div class="form-group">
                                    <asp:FileUpload ID="fuResume"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        placeholder=".doc, .docx, .pdf extension only"
                                         />

                                </div>
                            </div>



                        </div>

                        <div class="form-group">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button button-contactForm boxed-btn mr-4" OnClick="btnUpdate_Click" />

                        </div>

                    </div>
                </div>

            </div>

        </div>
    </section>
</asp:Content>

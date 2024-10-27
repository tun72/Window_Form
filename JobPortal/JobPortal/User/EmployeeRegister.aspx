<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="EmployeeRegister.aspx.cs" Inherits="JobPortal.User.EmployeeRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="mt-20">
        <div class="container">
            <div class="row">
                <div class="col-12 pb-20">
                    <asp:Label
                        ID="lblMsg"
                        runat="server"
                        Text="Label"
                        Visible="false"></asp:Label>
                </div>


                <div class="col-lg-6">
                    <img
                        src="https://www.contactmonkey.com/cm_wp/wp-content/uploads/2024/04/How-to-Improve-Employee-Experience_650-2-1.jpg"
                        class="img-fluid shadow-md rounded-top rounded-left" />
                    <img
                        src="https://www.aihr.com/wp-content/uploads/employee-experience-components.png"
                        class="img-fluid shadow-md rounded-buttom rounded-right" />
                </div>

                <div class="col-lg-6">
                    <div
                        class="form-contact contact_form"
                        action="contact_process.php"
                        method="post"
                        id="contactForm">
                        <div class="row">
                            <div class="col-12 mb-3">
                                <h5 class="font-weight-bold">Authentication Information</h5>
                            </div>
                            <div class="col-12">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtUsername"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Username'"
                                        placeholder="Username"
                                        required>
                                    </asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-12">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtEmail"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Email'"
                                        placeholder="Email"
                                        required>
                                    </asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPassword"
                                        runat="server"
                                        TextMode="Password"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Password'"
                                        placeholder="Password"
                                        required>
                                    </asp:TextBox>
                                </div>
                            </div>
                            <div class="col-sm-6">

                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtConfirmPassword"
                                        runat="server"
                                        TextMode="Password"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Confrim Password'"
                                        placeholder="Password"
                                        required>
                                    </asp:TextBox>

                                    <asp:CompareValidator
                                        ID="CompareValidator1"
                                        runat="server"
                                        ErrorMessage="Password and ConfirmPassword Must be the same."
                                        ControlToCompare="txtPassword"
                                        ControlToValidate="txtConfirmPassword"
                                        ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small">
                                    </asp:CompareValidator>
                                </div>
                            </div>

                            <div class="col-12 mb-3">
                                <h5 class="h5 font-weight-bold">Company Information</h5>
                            </div>

                            <!-- Company Name -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtCompanyName"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter Company Name'"
                                        placeholder="Company Name"
                                        required>
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidatorCompanyName"
                                        runat="server"
                                        ControlToValidate="txtCompanyName"
                                        ErrorMessage="Company Name is required"
                                        ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>

                            <!-- Company Address -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtCompanyAddress"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter Company Address'"
                                        placeholder="Company Address"
                                        required>
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidatorCompanyAddress"
                                        runat="server"
                                        ControlToValidate="txtCompanyAddress"
                                        ErrorMessage="Company Address is required"
                                        ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>



                            

                            <!-- Phone -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPhone"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter Phone Number'"
                                        placeholder="Phone Number"
                                        required>
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator
                                        ID="RequiredFieldValidatorPhone"
                                        runat="server"
                                        ControlToValidate="txtPhone"
                                        ErrorMessage="Phone Number is required"
                                        ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>

                            <!-- Position -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPosition"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter Position'"
                                        placeholder="Position">
                                    </asp:TextBox>
                                </div>
                            </div>





                            <!-- Company Website -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtCompanySite"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter Company Website'"
                                        placeholder="Company Website">
                                    </asp:TextBox>
                                </div>
                            </div>



                            <!-- Company Image -->
                            <div class="col-sm-6">
                                <div class="form-group">
                                    <asp:FileUpload ID="fuCompanyLogo" runat="server" CssClass="form-control w-100 p-2" ToolTip=".jpg, .jpeg, .png extension only" />
                                </div>
                            </div>

                            <!-- Company Country -->
                            <div class="col-12">
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
                                        ControlToValidate="ddlCountry">
                                    </asp:RequiredFieldValidator>
                                    <asp:SqlDataSource
                                        ID="SqlDataSource1"
                                        runat="server"
                                        ConnectionString="<%$ ConnectionStrings:cs %>"
                                        SelectCommand="SELECT [CountryName] FROM [Country]"></asp:SqlDataSource>
                                </div>
                            </div>




                            <div class="form-group">
                                <asp:Button runat="server" ID="btnRegister" runat="server" Text="Register" CssClass="button button-contactForm boxed-btn mr-4"   OnClick="btnRegister_Click"  />
                                <span class="link font-small">Already Register?<a href="../User/Login.aspx" class="items-link text-info">Click Here</a>
                                </span>
                            </div>

                        </div>
                    </div>

                </div>

            </div>
    </section>
</asp:Content>

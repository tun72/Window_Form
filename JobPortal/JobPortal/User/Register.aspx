<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master"
    AutoEventWireup="true" CodeBehind="Register.aspx.cs"
    Inherits="JobPortal.User.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content
    ID="Content2"
    ContentPlaceHolderID="ContentPlaceHolder1"
    runat="server">
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
                        src=" https://images.hdqwalls.com/wallpapers/skyscraper-city-buildings-4k-7n.jpg"
                        class="img-fluid shadow-lg rounded-top rounded-left" />
                    <img
                        src="https://www.pixel4k.com/wp-content/uploads/2018/09/skyscraper-building-architecture-4k_1538065231.jpg"
                        class="img-fluid shadow-lg rounded-buttom rounded-right" />
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
                                        required></asp:TextBox>
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
                                        required></asp:TextBox>
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
                                        required></asp:TextBox>
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
                                        required></asp:TextBox>

                                    <asp:CompareValidator
                                        ID="CompareValidator1"
                                        runat="server"
                                        ErrorMessage="Password and ConfirmPassword Must be the same."
                                        ControlToCompare="txtPassword"
                                        ControlToValidate="txtConfirmPassword"
                                        ForeColor="Red" Display="Dynamic" SetFocusOnError="true" Font-Size="Small"></asp:CompareValidator>
                                </div>
                            </div>

                            <div class="col-12 mb-3">
                                <h5 class="h5 font-weight-bold">Personal Information</h5>
                            </div>
                            <div class="col-12">
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
                            <div class="col-12">
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

                            <div class="col-12">
                                <div class="form-group">
                                    <asp:TextBox
                                        ID="txtPhone"
                                        runat="server"
                                        CssClass="form-control w-100"
                                        onfocus="this.placeholder = ''"
                                        onblur="this.placeholder = 'Enter your Phone Number'"
                                        placeholder="Phone"
                                        ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-12">
                                <div class="form-group">
                                    <asp:DropDownList
                                        ID="ddlCountry"
                                        runat="server"
                                        DataSourceID="SqlDataSource1"
                                        CssClass="w-100"
                                        AppendDataBoundItem="true"
                                        DataTextField="CountryName"
                                        DataValueField="CountryName"
                                        >
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
                        </div>

                        <div class="form-group">
                            <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="button button-contactForm boxed-btn mr-4" OnClick="btnRegister_Click" />
                            <br /><br />
                            <span class="link font-small">Already Register?<a href="../User/Login.aspx" class="items-link text-info">Click Here</a>
                            </span>
                   <br />
                            <span class="link font-small">Employor ?<a href="../User/EmployeeRegister.aspx" class="items-link text-info">Click Here</a>
                           </span>
                        </div


                    </div>
                </div>

            </div>

        </div>
    </section>
</asp:Content>

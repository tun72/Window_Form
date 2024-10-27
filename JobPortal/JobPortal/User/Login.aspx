<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JobPortal.User.Login" %>

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


                <div class="col-lg-6 mx-auto">
                    <div
                        class="form-contact contact_form"
                        action="contact_process.php"
                        method="post"
                        id="contactForm">
                        <div class="row">
                            <div class="col-12 mb-3">
                                <h5 class="font-weight-bold">Login Your Account</h5>
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
                            <div class="col-sm-12">
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


                            <div class="col-sm-12 form-group">

                                <asp:DropDownList
                                    ID="role"
                                    runat="server"
                                    CssClass="w-100">
                                    <asp:ListItem>Selecrt Role</asp:ListItem>
                                    <asp:ListItem Value="0">Admin</asp:ListItem>
                                    <asp:ListItem Value="1">User</asp:ListItem>
                                    <asp:ListItem Value="2">Employer</asp:ListItem>
                                </asp:DropDownList>

                            </div>

                            <div class="col-sm-12">
                                <div class="form-group" server="">
                                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button button-contactForm boxed-btn mr-4" OnClick="btnLogin_Click" />


                                    <span class="link font-small">New User?<a href="../User/Register.aspx" class="items-link text-info">Register Now</a>
                                    </span>
                                </div>
                            </div>
                        </div>



                    </div>
                </div>

            </div>

        </div>
    </section>
</asp:Content>

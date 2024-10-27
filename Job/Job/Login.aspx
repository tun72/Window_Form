<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
        }

        .auto-style2 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="Log In"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_login_job_seeker" runat="server" Style="cursor: pointer" Font-Bold="True" Height="40px" Text="Job Seeker" Width="180px" OnClick="btn_login_job_seeker_Click" CausesValidation="False" />
    <br />
    <br />
    <asp:Button ID="btn_login_employeers" runat="server" Style="cursor: pointer" Font-Bold="True" Height="40px" Text="Employeer" Width="180px" OnClick="btn_login_employeers_Click" CausesValidation="False" />
    <br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="panel_job_seeker" runat="server">
          <asp:Label ID="Label6" runat="server" Text="Job Seeker Login" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="llblj" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <p style="text-align: center">
            <img style="width: 200px; height: 200px;" src="images/login.png" alt="This is login image" />
        </p>
        <br />
        <p style="text-align: center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_login_seeker_name" runat="server" BorderColor="Silver" CssClass="auto-style1" Height="30px" Width="230px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_login_seeker_name" ErrorMessage="Enter your user_name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_login_seeker_name_pass" runat="server" BorderColor="Silver" CssClass="auto-style2" Height="30px" TextMode="Password" Width="230px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your password" ControlToValidate="txt_login_seeker_name_pass" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:CheckBox ID="checkbx_login_seeker" Text=" Remember Me" runat="server" />
            <br />
            <asp:Button ID="btn_login_seeker_login" runat="server" style="cursor:pointer" BackColor="#009900" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="45px" Text="Log In" Width="130px" OnClick="btn_login_seeker_login_Click" UseSubmitBehavior="False" />
            <br />
            <asp:HyperLink ID="btn_login_seeker_forgot_pass" runat="server" ForeColor="Red">Forget Password?</asp:HyperLink>
        </p>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Don&#39;t have an account
        <asp:Button ID="btn_login_seeker_go_create" runat="server" Text="Create Account" Height="36px" Width="130px" Font-Bold="True" PostBackUrl="~/Register.aspx" />
        <br />
        <br />
    </asp:Panel>
    <asp:Panel ID="panel_employeer" runat="server">
        <asp:Label ID="Label5" runat="server" Text="Employee Login" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="llble" runat="server"  Font-Bold="True" ForeColor="#009900"></asp:Label>
        <p style="text-align: center">
            <img style="width: 200px; height: 200px;" src="images/login.png" alt="This is login image" />
        </p>
        <br />
        <p style="text-align: center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_login_employeer_name" runat="server" BorderColor="Silver" Height="30px" Width="230px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_login_employeer_name" ErrorMessage="Enter your user_name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_login_employeer_pass" runat="server" BorderColor="Silver" Height="30px" TextMode="Password" Width="230px"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter your password" ControlToValidate="txt_login_employeer_pass" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:CheckBox ID="checkbx_login_employeer" Text=" Remember Me" runat="server" />
            <br />
            <asp:Button ID="btn_login_employeer_login" runat="server"  style="cursor:pointer" BackColor="#009900" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="45px" Text="Log In" Width="130px" OnClick="btn_login_employeer_login_Click" />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Red">Forget Password?</asp:HyperLink>
        </p>
        <br />
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Don&#39;t have an account
        <asp:Button ID="btn_login_employeer_go_login" runat="server" Text="Create Account" Height="36px" Width="130px" Font-Bold="True" PostBackUrl="~/Register.aspx" />
        <br />
        <br />
    </asp:Panel>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="Register"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_register_job_seeker" runat="server" Style="cursor: pointer" Font-Bold="True" Height="40px" Text="Job Seeker" Width="180px" CausesValidation="False" OnClick="btn_register_job_seeker_Click" />
    <br />
    <br />
    <asp:Button ID="btn_register_employeers" runat="server" Style="cursor: pointer" Font-Bold="True" Height="40px" Text="Employeer" Width="180px" CausesValidation="False" OnClick="btn_register_employeers_Click" />
    <br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="rpanel_job_seeker" runat="server">
        <asp:Label ID="Label6" runat="server" Text="Job Seeker Registration" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="rlblj" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" HeaderText="You must need to fill " />
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Style="margin-right: 15px" Text="Email"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Email is not valid" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txt_register_job_seeker_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <asp:TextBox ID="txt_register_job_seeker_email" Style="margin-left: 51px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label3" Style="margin-left: 70px; margin-right: 15px" runat="server" Text="User Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_register_job_seeker_user_name" ErrorMessage="Enter UserName" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_register_job_seeker_user_name" Style="margin-left: 20px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Style="margin-right: 15px" Text="Password"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_register_job_seeker_pass" ErrorMessage="Enter you password" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_register_job_seeker_pass" Style="margin-left: 27px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label17" runat="server" Style="margin-left: 53px; margin-right: 15px" Text="Re-type Password"></asp:Label>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_register_job_seeker_pass" ControlToValidate="txt_register_job_seeker_re_pass" ErrorMessage="Password does not match " ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
        <asp:TextBox ID="txt_register_job_seeker_re_pass" Style="margin-left: -3px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="txt_register_job_seeker_checkbox" runat="server" Text="I accept the terms and condition" />
        <br />
        <br />
        <p style="text-align:center;">
            <asp:Button ID="btn_register_job_seeker_go_register" style="cursor:pointer" runat="server" Text="Register" BackColor="#009900" CssClass="auto-style1" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="35px" Width="130px" OnClick="btn_register_job_seeker_go_register_Click" />
        </p>
        <br />
        <br />
        <br />
    </asp:Panel>
    <asp:Panel ID="rpanel_employeer" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Employeer Registration" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="rlble" runat="server" Font-Bold="True" ForeColor="Red" ></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="You must need to fill " />
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Style="margin-right: 15px" Text="Email"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email is not valid" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txt_register_employeer_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <asp:TextBox ID="txt_register_employeer_email" Style="margin-left: 51px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label18" Style="margin-left: 70px; margin-right: 15px" runat="server" Text="User Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txt_register_employeer_user_name" ErrorMessage="Enter UserName" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_register_employeer_user_name" Style="margin-left: 20px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Style="margin-right: 15px" Text="Password"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_register_employeer_pass" ErrorMessage="Enter you password" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_register_employeer_pass" Style="margin-left: 27px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Style="margin-left: 53px; margin-right: 15px" Text="Re-type Password"></asp:Label>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txt_register_employeer_pass" ControlToValidate="txt_register_employeer_re_pass" ErrorMessage="Password does not match " ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
        <asp:TextBox ID="txt_register_employeer_re_pass" Style="margin-left: -3px" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="txt_register_employeer_checkbox" runat="server" Text="I accept the terms and condition" />
        <br />
        <br />
        <p style="text-align:center;">
            <asp:Button ID="btn_register_employeer_go_register" style="cursor:pointer" runat="server" Text="Register" BackColor="#009900" CssClass="auto-style1" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="35px" Width="130px" OnClick="btn_register_employeer_go_register_Click" />
        </p>
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>


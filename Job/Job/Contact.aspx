<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 341px;
            height: 200px;
        }
        </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel ID="panel_office_address" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Our Officce Address" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <address style="text-align:center">
            Jobs Portal<br />
            8th Floor - West<br />
            Raisul Building (Old BSRS)<br />
            12, Bokshi Bazar C/A<br />
            Dhaka-1215<br />
            Bangladesh<br />
        </address>
        <br />
        <br />
    </asp:Panel>
    <asp:Panel ID="panel_message_me" runat="server" BorderStyle="None">
        <asp:Label ID="Label3" runat="server" Text="Message Us" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_msg" runat="server" Font-Size="Large" ></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Name" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_name" runat="server" BorderColor="Silver" Height="30px" Width="160px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your name" ForeColor="Red" ControlToValidate="txt_name" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Contact Number"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_number" runat="server" BorderColor="Silver" Height="30px" Width="160px" TextMode="Phone"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter your phone number" ControlToValidate="txt_number" ForeColor="Red" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Email"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_email" runat="server" BorderColor="Silver" Height="30px" Width="160px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter your email" ControlToValidate="txt_email" ForeColor="Red" ></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="Comments"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <textarea runat="server" id="txt_comments" style="vertical-align: middle" name="S1"></textarea>
        <br />
        <br /> <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_messge_submit" runat="server" Style="cursor:pointer" Text="Submit" Font-Bold="True" Font-Size="Large" Height="40px" Width="160px" OnClick="btn_messge_submit_Click" />
        <br />
        <br />
    </asp:Panel>
    

    
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="Contact Us"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_office_address" runat="server" Style="cursor:pointer" Font-Bold="True" Height="40px" Text="Office Address" Width="180px" OnClick="btn_office_address_Click" CausesValidation="False" />
    <br />
    <br />
    <asp:Button ID="btn_mail_us" runat="server" Style="cursor:pointer" Font-Bold="True" Height="40px" Text="Message Us" Width="180px" OnClick="btn_mail_us_Click" />
    <br />
    <br />
    <br />
</asp:Content>



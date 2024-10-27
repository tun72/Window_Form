<%@ Page Title="" Language="C#" MasterPageFile="~/employeer/Employee.master" AutoEventWireup="true" CodeFile="AddJobs.aspx.cs" Inherits="employeer_AddJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            text-align: center;
            width: 30%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label16" runat="server" Text="Add Your Jobs Information" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lbljobcongo" runat="server"></asp:Label>
    <br />


    <table cellpadding="10" cellspacing="5" class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Large" Text="Job Title "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_title" runat="server" Height="30px" Width="270px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_job_title" ErrorMessage="Enter Job Title" ForeColor="Red">Enter Job Title</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Large" Text="Catagory"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drp_job_catagory" runat="server" Height="30px" Width="200px">
                    <asp:ListItem Value="-1">Select Catagory</asp:ListItem>
                    <asp:ListItem>IT &amp; Telecommunication</asp:ListItem>
                    <asp:ListItem>Banking &amp; Finance</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="drp_job_catagory" ErrorMessage="RequiredFieldValidator" ForeColor="Red" InitialValue="-1">Enter Catagory</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Large" Text="No. Of Vacancy"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_vacancy" runat="server" Height="30px" Width="70px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_job_vacancy" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter Vacancy </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Large" Text="Job Discription"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_discription" runat="server" Height="71px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_job_discription" ErrorMessage="Enter Job Discription" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Large" Text="Job Nature"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drp_job_nature" runat="server" Height="30px" Width="200px">
                    <asp:ListItem Value="-1">Select Job Type</asp:ListItem>
                    <asp:ListItem>Part Time</asp:ListItem>
                    <asp:ListItem>Full Time</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ErrorMessage="Enter Job Nature" ForeColor="Red" InitialValue="-1" ControlToValidate="drp_job_nature"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Large" Text="Educational Requirements"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_education_requiremnt" runat="server" Height="71px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_job_education_requiremnt" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter Educational Requirements</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Large" Text="Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_location" runat="server" Height="30px" Width="270px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_job_location" ErrorMessage="Enter Job Location" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Large" Text="Salary"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_salary" runat="server" Height="30px" Width="270px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_job_salary" ErrorMessage="Enter Salary" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Job Deadline"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_job_deadline" runat="server" Height="30px" Width="200px"></asp:TextBox>
            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="22px" ImageUrl="~/images/Calendar.png" Width="29px" OnClick="ImageButton1_Click" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_job_deadline" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter Job Deadline</asp:RequiredFieldValidator>
                <br />
                <asp:Calendar ID="job_calender" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="job_calender_SelectionChanged1">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
        </tr>
                <tr>
            <td class="auto-style2">
                <asp:TextBox ID="my_hidden" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btn_submit" runat="server" Font-Bold="True" Font-Size="X-Large" Height="45px" Text="Submit" Width="159px" OnClick="btn_submit_Click" />
                    </td>
                       
        </tr>
        
    </table>



</asp:Content>


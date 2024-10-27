<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="MyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        #ContentPlaceHolder1_GridView3
        {
            margin:0 auto;
        }
        .auto-style2 {
            margin-right: 0px;
        }
        .auto-style3 {}
        .auto-style4 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    &nbsp;   
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Text="My Profile"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btn_my_view_resume" runat="server" Style="cursor: pointer" Text="View Resume" Height="40px" Width="180px" CausesValidation="False" Font-Bold="True" OnClick="btn_my_view_resume_Click" />
    <br />
    <br />
    <asp:Button ID="btn_my_personal_info" runat="server" Style="cursor: pointer" Text="Edit Personal Information" Height="40px" Width="180px" Font-Bold="True" CausesValidation="False" OnClick="btn_my_personal_info_Click" />
    <br />
    <br />
    <asp:Button ID="btn_my_educational_info" runat="server" Style="cursor: pointer" Text="Edit Education Information" Height="40px" Width="180px" Font-Bold="True" CausesValidation="False" OnClick="btn_my_educational_info_Click" />
    <br />
    <br />
    <asp:Button ID="btn_my_other_info" runat="server" Style="cursor: pointer" Text="Edit Other Information" Height="40px" Width="180px" Font-Bold="True" CausesValidation="False" OnClick="btn_my_other_info_Click" />
    <br />
    <br />
    <asp:Button ID="btn_my_password_change" runat="server" Style="cursor: pointer" Text="Reset Login Information" Height="40px" Width="180px" Font-Bold="True" CausesValidation="False" OnClick="btn_my_password_change_Click"  />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--This is personal information--%>
    <asp:Panel ID="pnl_personal_info" runat="server">
        <asp:Label ID="Label12" runat="server" Text="Personal Information" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary3" runat="server" ForeColor="Red" ValidationGroup="p" />
        <br />
        <%--<br />--%>
        <asp:Label ID="Label1" Style="margin-right: 35px" runat="server" Text="First Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txt_myfname" ErrorMessage="Enter Name" ForeColor="Red" ValidationGroup="p">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_myfname" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" Style="margin-left: 45px" Text="Present Address"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txt_mypresent_address" ErrorMessage="Enter address" ForeColor="Red" ValidationGroup="p">*</asp:RequiredFieldValidator>
        <textarea runat="server" id="txt_mypresent_address" style="vertical-align: middle"></textarea>
        <br />
        <br />
        <asp:Label ID="Label3" Style="margin-right: 47px" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txt_mylname" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" Style="margin-right: 12px" runat="server" Text="Father's Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txt_myfathersname" ErrorMessage="Enter Fathers Name" ForeColor="Red" ValidationGroup="p">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_myfathersname" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Style="margin-left: 33px" Text="Parmanent Address"></asp:Label>
        <textarea runat="server" id="txt_mypermanent_address" style="vertical-align: middle"></textarea>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Style="margin-right: 5px" Text="Mother's Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txt_mymothersname" ErrorMessage="Enter Mothers Name" ForeColor="Red" ValidationGroup="p">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_mymothersname" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Style="margin-left: 99px" Text="Gender"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="drp_mygender" ErrorMessage="Select Gender" ForeColor="Red" ValidationGroup="p" InitialValue="-1">*</asp:RequiredFieldValidator>
        <asp:DropDownList ID="drp_mygender" runat="server" Height="30px">
            <asp:ListItem Value="-1" Text="Select Gender"></asp:ListItem>
            <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Style="margin-right: 65px" Text="Religon"></asp:Label>
        <asp:TextBox ID="txt_myreligon" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Style="margin-left: 44px" Text="Mobile Number"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_my_fmblno" ErrorMessage="Enter valid phone number" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="p">*</asp:RegularExpressionValidator>
        <asp:TextBox ID="txt_my_fmblno" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Style="margin-right: 13px" Text="Marital Status"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="drp_mymarried" ErrorMessage="Marritual Status" ForeColor="Red" ValidationGroup="p" InitialValue="-1">*</asp:RequiredFieldValidator>
        <asp:DropDownList ID="drp_mymarried" runat="server" Height="30px">
            <asp:ListItem Value="-1" Text="Select Status"></asp:ListItem>
            <asp:ListItem Value="Married" Text="Married"></asp:ListItem>
            <asp:ListItem Value="Unmarried" Text="Unmarried"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label9" runat="server" Style="margin-left: 80px" Text="Optional Mobile Number"></asp:Label>
        &nbsp;<asp:TextBox ID="txt_my_omblno" runat="server" Height="30px" Width="165px"></asp:TextBox>
        <br />
        <br />
        &nbsp;<br />
        <br />
        <br />
        <p style="text-align: center">
            <asp:Button ID="btn_save_my_personalinfo" runat="server" Style="cursor: pointer" Text="Save" BackColor="#009900" Font-Bold="True" Height="30px" Width="80px" Font-Size="Medium" ForeColor="Black" ValidationGroup="p" OnClick="btn_save_my_personalinfo_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btn_cancel_my_personalinfo" runat="server" BackColor="White" Font-Bold="True" Height="30px" Style="cursor: pointer" Text="Cancel" Width="80px" Font-Size="Medium" OnClick="btn_cancel_my_personalinfo_Click" />
        </p>
        <br />
        <asp:TextBox ID="my_hidden" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
        <br />
        <br />
    </asp:Panel>
    <%--    This is educationl information--%>
    <asp:Panel ID="pnl_education_info" runat="server">
        <asp:Label ID="Label16" runat="server" Text="Educational Information" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblmyp" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <br />
        <%-- SSC level--%>
        <asp:Label ID="Label17" runat="server" Text="SSC Level" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="x" />
        <br />
        <asp:Label ID="Label18" runat="server" Style="margin-right: 15px" Text="Major Group"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="drp_mye_ssc_majorgroup" ErrorMessage="Select Group" ForeColor="Red" ValidationGroup="x" InitialValue="-1">*</asp:RequiredFieldValidator>
        <asp:DropDownList ID="drp_mye_ssc_majorgroup" runat="server" Height="35px" Width="89px">
            <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Science" Value="Science"></asp:ListItem>
            <asp:ListItem Text="Commerce" Value="Commerce"></asp:ListItem>
            <asp:ListItem Text="Arts" Value="Arts"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label21" runat="server" Style="margin-left: 40px" Text="Passing Year"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="drp_mye_ssc_passingyear" ErrorMessage="Select Year" ForeColor="Red" ValidationGroup="x" InitialValue="-1">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;<asp:DropDownList ID="drp_mye_ssc_passingyear" runat="server" Height="35px">
            <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            <asp:ListItem>2016</asp:ListItem>
            <asp:ListItem>2015</asp:ListItem>
            <asp:ListItem>2014</asp:ListItem>
            <asp:ListItem>2013</asp:ListItem>
            <asp:ListItem>2012</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2010</asp:ListItem>
            <asp:ListItem>2009</asp:ListItem>
            <asp:ListItem>2008</asp:ListItem>
            <asp:ListItem>2007</asp:ListItem>
            <asp:ListItem>2006</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2004</asp:ListItem>
            <asp:ListItem>2003</asp:ListItem>
            <asp:ListItem>2002</asp:ListItem>
            <asp:ListItem>2001</asp:ListItem>
            <asp:ListItem>2000</asp:ListItem>
            <asp:ListItem>1999</asp:ListItem>
            <asp:ListItem>1998</asp:ListItem>
            <asp:ListItem>1997</asp:ListItem>

        </asp:DropDownList>
        <p style="text-align: right">
            <asp:Button ID="btn_mye_ssc_save" runat="server" Style="cursor: pointer" BackColor="#009900" Font-Bold="True" Font-Size="Medium" Text="Save" Width="80px" ValidationGroup="x" OnClick="btn_mye_ssc_save_Click" />
            &nbsp;
            <asp:Button ID="btn_mye_ssc_cancel" runat="server" Style="cursor: pointer" Font-Bold="True" Font-Size="Medium" Text="Cancel" Width="80px" OnClick="btn_mye_ssc_cancel_Click" />
        </p>
        <asp:Label ID="Label19" runat="server" Style="margin-right: 8px" Text="Institue Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_mye_ssc_institute" ErrorMessage="Enter Institue" ForeColor="Red" ValidationGroup="x">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_mye_ssc_institute" runat="server" Height="25px" Width="150px"></asp:TextBox>
        <asp:Label ID="Label20" runat="server" Style="margin-left: 10px" Text="Result"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txt_mye_sss_result" ErrorMessage="Enter Result" ForeColor="Red" ValidationGroup="x">*</asp:RequiredFieldValidator>
        &nbsp;
            <asp:TextBox ID="txt_mye_sss_result" runat="server" Height="25px" Width="70px"></asp:TextBox>
        <br />
        <br />
        <br />
        <hr />
        <hr />
        <br />
        <%-- HSC Level--%>
        <asp:Label ID="Label22" runat="server" Text="HSC Level" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="y" />
        <br />
        <asp:Label ID="Label23" runat="server" Style="margin-right: 15px" Text="Major Group"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="drp_mye_hsc_majorgroup" ErrorMessage="Select Maj Group" ForeColor="Red" InitialValue="-1" ValidationGroup="y">*</asp:RequiredFieldValidator>
        <asp:DropDownList ID="drp_mye_hsc_majorgroup" runat="server" Height="35px" Width="89px">
            <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Science" Value="Science"></asp:ListItem>
            <asp:ListItem Text="Commerce" Value="Commerce"></asp:ListItem>
            <asp:ListItem Text="Arts" Value="Arts"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label24" runat="server" Style="margin-left: 40px" Text="Passing Year"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="drp_mye_hsc_passingyear" ErrorMessage="Select Year" ForeColor="Red" InitialValue="-1" ValidationGroup="y">*</asp:RequiredFieldValidator>
        &nbsp;&nbsp;<asp:DropDownList ID="drp_mye_hsc_passingyear" runat="server" Height="35px">
            <asp:ListItem Text="Select" Value="-1"></asp:ListItem>
            <asp:ListItem>2016</asp:ListItem>
            <asp:ListItem>2015</asp:ListItem>
            <asp:ListItem>2014</asp:ListItem>
            <asp:ListItem>2013</asp:ListItem>
            <asp:ListItem>2012</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2010</asp:ListItem>
            <asp:ListItem>2009</asp:ListItem>
            <asp:ListItem>2008</asp:ListItem>
            <asp:ListItem>2007</asp:ListItem>
            <asp:ListItem>2006</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2004</asp:ListItem>
            <asp:ListItem>2003</asp:ListItem>
            <asp:ListItem>2002</asp:ListItem>
            <asp:ListItem>2001</asp:ListItem>
            <asp:ListItem>2000</asp:ListItem>
            <asp:ListItem>1999</asp:ListItem>
            <asp:ListItem>1998</asp:ListItem>
            <asp:ListItem>1997</asp:ListItem>

        </asp:DropDownList>
        <p style="text-align: right">
            <asp:Button ID="btn_mye_hsc_save" runat="server" Style="cursor: pointer" BackColor="#009900" Font-Bold="True" Font-Size="Medium" Text="Save" Width="80px" ValidationGroup="y" OnClick="btn_mye_hsc_save_Click" />
            &nbsp;
            <asp:Button ID="btn_mye_hsc_cancel" runat="server" Style="cursor: pointer" Font-Bold="True" Font-Size="Medium" Text="Cancel" Width="80px" OnClick="btn_mye_hsc_cancel_Click" />
        </p>
        <asp:Label ID="Label25" runat="server" Style="margin-right: 8px" Text="Institue Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txt_mye_hsc_institute" ErrorMessage="Enter institute" ForeColor="Red" ValidationGroup="y">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_mye_hsc_institute" runat="server" Height="25px" Width="150px"></asp:TextBox>
        <asp:Label ID="Label26" runat="server" Style="margin-left: 10px" Text="Result"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txt_mye_hsc_result" ErrorMessage="Enter Result" ForeColor="Red" ValidationGroup="y">*</asp:RequiredFieldValidator>
        &nbsp;
            <asp:TextBox ID="txt_mye_hsc_result" runat="server" Height="25px" Width="70px"></asp:TextBox>
        <br />
        <br />
        <br />
        <hr />
        <hr />
        <br />
        <%--  Honors Level--%>
        <asp:Label ID="Label27" runat="server" Text="Bachelor/Honors Level" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label28" runat="server" Style="margin-right: 15px" Text="Degree Title"></asp:Label>
        <asp:TextBox ID="txt_mye_honors_dgrtitle" runat="server" Height="25px" Width="160px"></asp:TextBox>
        <asp:Label ID="Label31" runat="server" Style="margin-right: 15px" Text="Major"></asp:Label>
        <asp:TextBox ID="txt_mye_honors_major" runat="server" Height="25px" Width="160px"></asp:TextBox>
        <p style="text-align: right">
            <asp:Button ID="btn_my_hnr_save" runat="server" Style="cursor: pointer" BackColor="#009900" Font-Bold="True" Font-Size="Medium" Text="Save" Width="80px" OnClick="btn_my_hnr_save_Click" />
            &nbsp;
            <asp:Button ID="btn_my_hnrs_cancel" runat="server" Style="cursor: pointer" Font-Bold="True" Font-Size="Medium" Text="Cancel" Width="80px" OnClick="btn_my_hnrs_cancel_Click" />
        </p>
        <asp:Label ID="Label29" runat="server" Style="margin-right: 8px" Text="Institue Name"></asp:Label>
        <asp:TextBox ID="txt_my_hnrsinstitue" runat="server" Height="25px" Width="150px"></asp:TextBox>
        <asp:Label ID="Label30" runat="server" Style="margin-left: 10px" Text="Result"></asp:Label>
        &nbsp;
            <asp:TextBox ID="txt_my_hnrsresult" runat="server" Height="25px" Width="150px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
    <%--    This is other information --%>
    <asp:Panel ID="pnl_other_info" runat="server">
        <asp:Label ID="Label32" runat="server" Text="Other Information" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label33" runat="server" Text="Upload Your Picture" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <asp:FileUpload ID="upld_my_pic" runat="server" />&nbsp;
        <asp:Button ID="btn_mypicture_upload" runat="server" Text="Upload"  CssClass="auto-style1" Font-Bold="True" Font-Size="Medium" Height="30px" Width="100px" OnClick="btn_mypicture_upload_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_pic" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <hr />
        <hr />
        <br />
        <asp:Label ID="Label34" runat="server" Text="Upload Your CV" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <asp:FileUpload ID="upld_my_cv" runat="server" />&nbsp;
        <asp:Button ID="btn_mycv_upload" runat="server" Text="Upload" Font-Bold="True" Font-Size="Medium" Height="30px" Width="100px" OnClick="btn_mycv_upload_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_cv" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
    </asp:Panel>
    <%--this edit loginfo--%>
    <asp:Panel ID="pnl_my_loginfo" runat="server">
        <asp:Label ID="Label11" runat="server" Text="Change Your Login Info " Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_my_user" runat="server" ></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary4" runat="server" ForeColor="Red" ValidationGroup="my_l" />
        <br />
        <asp:Label ID="Label35" runat="server" Style="margin-right: 15px" Text="Email"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="txt_change_email" ErrorMessage="Enter mail" ForeColor="Red" ValidationGroup="my_l">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_change_email" ErrorMessage="Enter valid mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="my_l">*</asp:RegularExpressionValidator>
        <asp:TextBox ID="txt_change_email" runat="server" Height="25px" Width="213px" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="Label36" runat="server" Style="margin-right: 15px; margin-left: 20px" Text="User Name"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txt_change_user_name" ErrorMessage="Enter User_name" ForeColor="Red" ValidationGroup="my_l">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_change_user_name" runat="server" Height="25px" Width="160px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label37" runat="server" Style="margin-left: 27px;margin-right: 25px" Text="Change Password"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="txt_change_pass" ErrorMessage="Enter password" ForeColor="Red" ValidationGroup="my_l">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txt_change_pass" runat="server" Height="25px" Width="150px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label39" runat="server" Style="margin-left: 10px" Text="Password"></asp:Label>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txt_change_pass" ControlToValidate="txt_change_re_pass" ErrorMessage="Password don't match" ForeColor="Red" ValidationGroup="my_l">*</asp:CompareValidator>
        <asp:TextBox ID="txt_change_re_pass" runat="server" Height="25px" Width="150px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_my_log_chnge" style="cursor:pointer" runat="server" BackColor="#009900" CssClass="auto-style3" Font-Bold="True" Font-Size="Medium" Height="40px" Text="Change" ValidationGroup="my_l" Width="80px" OnClick="btn_my_log_chnge_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btn_my_log_cancel" style="cursor:pointer" runat="server" BackColor="White" CssClass="auto-style3" Font-Bold="True" Font-Size="Medium" Height="40px" Text="Cancel " ValidationGroup="my_l" Width="80px" OnClick="btn_my_log_cancel_Click" CausesValidation="False" />
        <br />
        <br />
        <br />

    </asp:Panel>
    <%--   This is my resume--%>
    <asp:Panel ID="pnl_my_resume" runat="server">
        <asp:Label ID="Label38" runat="server" Text="My personal information " Font-Size="X-Large" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lblcongo"></asp:Label>
        <asp:GridView ID="GridView3" GridLines="None" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                            <asp:Image ID="Image1" Height="200px" Width="200px" ImageUrl='<%# "data:Image/png;Base64,"+ Convert.ToBase64String((byte[])Eval("my_pic")) %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         <asp:GridView ID="GridView1" GridLines="None" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="auto-style2">
            <Columns>
                <asp:TemplateField> 
                    <ItemTemplate> 
                         <div class="my_personal_design">
                            <h1>First name</h1>
                            <p>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("First_name") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Last name</h1>
                            <p>
                                <asp:Label ID="Label40" runat="server" Text='<%# Bind("Last_name") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Father name</h1>
                            <p>
                                <asp:Label ID="Label41" runat="server" Text='<%# Bind("Father_name") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Mother name</h1>
                            <p>
                                <asp:Label ID="Label42" runat="server" Text='<%# Bind("Mother_name") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Religon</h1>
                            <p>
                                <asp:Label ID="Label43" runat="server" Text='<%# Bind("Religon") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Gender</h1>
                            <p>
                                <asp:Label ID="Label44" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Maritual Status</h1>
                            <p>
                                <asp:Label ID="Label45" runat="server" Text='<%# Bind("Maritual_Status") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Present Address</h1>
                            <p>
                                <asp:Label ID="Label46" runat="server" Text='<%# Bind("Present_address") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Parmanent Address</h1>
                            <p>
                                <asp:Label ID="Label47" runat="server" Text='<%# Bind("Parmanent_address") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Mobile number</h1>
                            <p>
                                <asp:Label ID="Label48" runat="server" Text='<%# Bind("Mobile") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                        <div class="my_personal_design">
                            <h1>Other mobile number</h1>
                            <p>
                                <asp:Label ID="Label49" runat="server" Text='<%# Bind("Omobile") %>'></asp:Label>
                            </p>
                        </div>
                        <br />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <hr />
         <asp:Label ID="Label10" runat="server" Text="My educational information " Font-Size="X-Large" Font-Bold="True" ForeColor="#009900"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" gridlines="None" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:TemplateField >
                    <ItemTemplate>
                        <div class="ssc_group">
                        <div class="my_education_design">
                            <h1>SSC group</h1>
                            <p>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ssc_group") %>'></asp:Label>
                            </p>
                        </div>
                      
                        <div class="my_education_design">
                            <h1>SSC year</h1>
                            <p>
                                <asp:Label ID="Label50" runat="server" Text='<%# Bind("ssc_year") %>'></asp:Label>
                            </p>
                        </div>
                        
                        <div class="my_education_design">
                            <h1>SSC institute</h1>
                            <p>
                                <asp:Label ID="Label51" runat="server" Text='<%# Bind("ssc_institute") %>'></asp:Label>
                            </p>
                        </div>
                      
                        <div class="my_education_design">
                            <h1>SSC result</h1>
                            <p>
                                <asp:Label ID="Label52" runat="server" Text='<%# Bind("ssc_result") %>'></asp:Label>
                            </p>
                        </div>
                            </div>
                        <br />
                        <div class="hsc_group">
                        <div class="my_education_design">
                            <h1>HSC group</h1>
                            <p>
                                <asp:Label ID="Label53" runat="server" Text='<%# Bind("hsc_group") %>'></asp:Label>
                            </p>
                        </div>
                        

                        <div class="my_education_design">
                            <h1>HSC year</h1>
                            <p>
                                <asp:Label ID="Label54" runat="server" Text='<%# Bind("hsc_year") %>'></asp:Label>
                            </p>
                        </div>
               
                        <div class="my_education_design">
                            <h1>HSC institute</h1>
                            <p>
                                <asp:Label ID="Label55" runat="server" Text='<%# Bind("hsc_institute") %>'></asp:Label>
                            </p>
                        </div>
               
                        <div class="my_education_design">
                            <h1>HSC result</h1>
                            <p>
                                <asp:Label ID="Label56" runat="server" Text='<%# Bind("hsc_result") %>'></asp:Label>
                            </p>
                        </div>
                            </div>
                        <br />
                        <div class="hnrs_group"">
                        <div class="my_education_design">
                            <h1>Title</h1>
                            <p>
                                <asp:Label ID="Label57" runat="server" Text='<%# Bind("hnrs_title") %>'></asp:Label>
                            </p>
                        </div>
                        
                        <div class="my_education_design">
                            <h1>Major</h1>
                            <p>
                                <asp:Label ID="Label58" runat="server" Text='<%# Bind("hnrs_major") %>'></asp:Label>
                            </p>
                        </div>
                         <div class="my_education_design">
                            <h1>Institute</h1>
                            <p>
                                <asp:Label ID="Label59" runat="server" Text='<%# Bind("hnrs_institue") %>'></asp:Label>
                            </p>
                        </div>
                        <div class="my_education_design">
                            <h1>Result</h1>
                            <p>
                                <asp:Label ID="Label60" runat="server" Text='<%# Bind("hnrs_result") %>'></asp:Label>
                            </p>
                        </div>
                            </div>
                        <br />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [First_name], [Last_name], [Father_name], [Mother_name], [Religon], [Gender], [Maritual_Status], [Present_address], [Parmanent_address], [Mobile], [Omobile] FROM [Job_seeker_account_info] WHERE ([user_name] = @user_name)">
            <SelectParameters>
                <asp:ControlParameter ControlID="my_hidden" Name="user_name" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [ssc_group], [ssc_year], [ssc_institute], [ssc_result], [hsc_group], [hsc_year], [hsc_institute], [hsc_result], [hnrs_title], [hnrs_major], [hnrs_result], [hnrs_institue] FROM [Job_seeker_account_info] WHERE ([user_name] = @user_name)">
            <SelectParameters>
                <asp:ControlParameter ControlID="my_hidden" Name="user_name" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView4" GridLines="None" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Label61" runat="server" Text="My CV"></asp:Label>
                        <br />
                        <asp:LinkButton ID="cv_download" runat="server" Text='<%# Eval("my_cv_name") %>' OnClick="cv_download_Click"  ></asp:LinkButton>
                    </ItemTemplate>

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DBCSJobPortal %>" SelectCommand="SELECT [my_pic] FROM [Job_seeker_account_info] WHERE (([user_name] = @user_name) AND ([my_pic] IS NOT NULL))">
            <SelectParameters>
                <asp:ControlParameter ControlID="my_hidden" Name="user_name" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ImageButton ID="btn_for_apply" runat="server" ImageUrl="~/images/applybtn.png" OnClick="btn_for_apply_Click" Width="148px" />
        <br />
        <br />

    </asp:Panel>
</asp:Content>


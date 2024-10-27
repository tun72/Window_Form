<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/EmployeeMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ViewResumeDetail.aspx.cs" Inherits="JobPortal.Employee.ViewResumeDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover" class="mb-10">
        <div class="container pt-4 pb-4">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

        <h3 class="text-center">Job List/Details</h3>

        <div class="row mr-lg-5 ml-lg-5">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="GridView1" CssClass="table table-hover table-bordered" 
                    EmptyDataText="No record to display..!" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="5" DataKeyNames="AppliedJobId" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>

                        <asp:BoundField DataField="Sr.No" HeaderText="Sr.No">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>


                        <asp:BoundField DataField="CompanyName" HeaderText="Company Name">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:BoundField DataField="Title" HeaderText="Job Title">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="FullName" HeaderText="User Name">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Phone" HeaderText="Experience">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:TemplateField HeaderText="Resume">
                            <ItemTemplate>
                                <asp:HyperLink ID="resume" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Resume", "../{0}") %>' CssClass="text-dark" runat="server">
                                 <i class="fa fa-download"></i> Download

                                 
                                </asp:HyperLink>
                                <asp:HiddenField ID="hdnJobId" runat="server" Value='<%# Eval("JobId") %>' Visible="false"></asp:HiddenField>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>




                        <%-- <asp:BoundField DataField="CreateDate" HeaderText="Posted Date" DataFormatString="{0:dd MMMM yyyy}">
                         <ItemStyle HorizontalAlign="Center" />
                     </asp:BoundField>--%>



                        <asp:CommandField CausesValidation="false" HeaderText="Delete" ShowDeleteButton="true" DeleteImageUrl="../assets/img/icon/trashIcon.png" ButtonType="Image">
                            <ControlStyle Height="25px" Width="25px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>


                    </Columns>
                    <HeaderStyle BackColor="#7200cf" ForeColor="White" />
                </asp:GridView>

            </div>

        </div>
    </div>
</asp:Content>

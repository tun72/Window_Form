<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="JobList.aspx.cs" Inherits="JobPortal.Admin.JobList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover" class="mb-10">

        <div class="container pt-4 pb-4">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

        <div class="input-group ml-70">

            <asp:HyperLink ID="linkBack" runat="server" Visible="false" NavigateUrl="~/Admin/ViewResumes.aspx" CssClass=" text-primary">< Back</asp:HyperLink>
        </div>

        <h3 class="text-center  mb-3">Job List/Details</h3>

        <div class="row mr-lg-5 ml-lg-5">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="GridView1" CssClass="table table-hover table-bordered" OnRowDataBound="GridView1_RowDataBound" EmptyDataText="No record to display..!" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="5" DataKeyNames="JobId" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand">
                    <Columns>

                        <asp:BoundField DataField="Sr.No" HeaderText="Sr.No">
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Title" HeaderText="Job Title">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="NoOfPost" HeaderText="NoOfPost">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Qualification" HeaderText="Qualification">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Experience" HeaderText="Experience">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>


                        <asp:BoundField DataField="LastDateToApply" HeaderText="Valid Till" DataFormatString="{0: dd MMMM yyyy}">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Country" HeaderText="Country">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="State" HeaderText="State">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>


                        <asp:BoundField DataField="CreateDate" HeaderText="Posted Date" DataFormatString="{0:dd MMMM yyyy}">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>

                        <asp:TemplateField HeaderText="Status">
                            <ItemTemplate>
                                <%# Convert.ToBoolean(Eval("isConfirm")) ? 
                                    "<span class='badge badge-success'>Confirmed</span>" : 
                                    "<span class='badge badge-warning'>Pending</span>" %>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>


                        <asp:TemplateField HeaderText="Confirm">
                            <ItemTemplate>

                                <asp:LinkButton ID="brnEditJob" runat="server"
                                    CommandName='<%# !Convert.ToBoolean(Eval("isConfirm")) ? "EditJobConfirm" : "EditJobPending" %>'
                                    CommandArgument='<%# Eval("JobId") %>'>
                                    <asp:Image ID="Img" runat="Server"
                                        ImageUrl='<%# !Convert.ToBoolean(Eval("isConfirm")) ? "../assets/img/icon/check.png" : "../assets/img/icon/pending.png" %>'
                                        Height="25px" />
                                </asp:LinkButton>




                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>


                        <asp:CommandField CausesValidation="false" HeaderText="Delete" ShowDeleteButton="true" DeleteImageUrl="../assets/img/icon/trashIcon.png" ButtonType="Image">
                            <ControlStyle Height="25px" Width="25px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:CommandField>

                      <%--  <asp:TemplateField HeaderText="Detail">
                            <ItemTemplate>
                                <asp:LinkButton ID="brnDetailJob" runat="server" CommandName="DetailJob" CommandArgument='<%# Eval("JobId") %>'>
                                    <asp:Image ID="Img1" runat="Server" ImageUrl="../assets/img/icon/detail.png" Height="25px" />
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                        </asp:TemplateField>--%>


                    </Columns>
                    <HeaderStyle BackColor="#7200cf" ForeColor="White" />
                </asp:GridView>

            </div>

        </div>
    </div>
</asp:Content>

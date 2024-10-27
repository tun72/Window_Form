<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="JobPortal.Admin.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <div style="background-image: url('../Images/bg.jpg'); width: 100%; height: 720px; background-repeat: no-repeat; background-size: cover" class="mb-10">
        <div class="container pt-4 pb-4">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>

        <h3 class="text-center">User List/Details</h3>

        <div class="row mr-lg-5 ml-lg-5">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="GridView1" CssClass="table table-hover table-bordered"
                     EmptyDataText="No record to display..!" AutoGenerateColumns="False"
                     OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="5"
                     DataKeyNames="UserId" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>

                        <asp:BoundField DataField="Sr.No" HeaderText="Sr.No">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="FullName" HeaderText="User Name">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Email" HeaderText="Email">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Phone" HeaderText="Phone No.">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>



                        <asp:BoundField DataField="Country" HeaderText="Country">
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>


           
           

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

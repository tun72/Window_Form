<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="BlogDetail.aspx.cs" Inherits="JobPortal.User.BlogDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DataList1" runat="server" CssClass="w-100">
        <ItemTemplate>



            <div class="d-flex align-items-center justify-content-center mt-25">
                <div class="w-50">


                   <%--<asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-secondary d-block mb-20" OnClick="btnBack_Click" />--%>

                    <img src='<%# Eval("ImageUrl") %>' alt="Blog Image" class="img-fluid rounded" width="100%" height="600" />

                    <div>
                        <h1 class="blog-title"><%# Eval("Title") %></h1>
                        <p class="badge badge-info">Category: <%# Eval("Category") %></p>
                    </div>




                    <div>
                        <p class="blog-content"><%# Eval("Content") %></p>
                    </div>



                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="Kota_FrontEnd.Manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner-area  blog-page text-center">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="mb-3 mt-5 bread">Manager</h1>

                    <form action="Manager.aspx" class="contact-form" runat="server">
                        <div class="row form-group">
                            <div class="col-md-12 mb-3 mb-md-0">
                                <input type="email" id="email" class="form-control" name="email" placeholder="Confirm Email to Edit product" onfocus="this.placeholder = ''" onblur="this.placeholder = 'email'" runat="server" required>
                            </div>
                        </div>

                        <div class="row align-items-center justify-content-center">
                            <asp:Button ID="btnMan" runat="server" Text="Search" class="btn btn-warning btn-sm py-2 px-5" OnClick="btnMan_Click" />
                        </div>

                        <div class="mt-10">
                            <asp:Label ID="lbl_error" runat="server" Text="" Visible="false"></asp:Label>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

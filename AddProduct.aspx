<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Kota_FrontEnd.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
	</br>
	</br>
    <h2 style="text-align: center;"><b>Add new product</b></h2>
    <section class="banner-area  blog-page text-center">
        <div class="banner">
            <div class="container ">
                <div class="row fill_height">
                    <div class="col-lg-4 offset-lg-4 fill_height">
                        <div class="banner_content">
                            <form action="AddProduct.aspx" method="post" class="contact-form" runat="server">
                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_code" class="form-control" placeholder="Product code" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_name" class="form-control" placeholder="Product name" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_type" class="form-control" placeholder="Product type" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_price" class="form-control" placeholder="Product price" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_special" class="form-control" placeholder="Product special" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_update" class="form-control" placeholder="Product update" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_details" class="form-control" placeholder="Product description" runat="server" required>
                                    </div>
                                </div>

                                <div class="row form-group">
                                    <div class="col-md-12 mb-3 mb-md-0">
                                        <input type="text" id="p_image" class="form-control" placeholder="Product Image" runat="server" required>
                                    </div>
                                </div>

                                <div class="row align-items-center justify-content-center">
                                    <asp:Button ID="btnAdd" type="submit" runat="server" Text="Add New Product" class="btn btn-warning py-2 px-5" OnClick="btnAdd_Click" />
                                </div>

                                <div class="mt-10">
                                    <asp:Label ID="lbl_error" runat="server" Text="" Visible="false"></asp:Label>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </br>
	</br>
	</br>
	</br>
	</br>
	</br>
</asp:Content>

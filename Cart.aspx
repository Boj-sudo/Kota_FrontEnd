<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Kota_FrontEnd.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="ftco-section ftco-cart">
        <div class="container">
            <div class="row">
                <div class="col-md-12 ftco-animate">
                    <div class="cart-list" id="showcart" runat="server">
                    </div>

                    <div class="cart_buttons d-flex flex-row align-items-start justify-content-start">
                        <div class="cart_buttons_inner ml-sm-auto d-flex flex-row align-items-start justify-content-start flex-wrap">
                            <div><a href="ClearCart.aspx" class="btn btn-warning py-3 px-4">Clear Cart</a></div>
                            &nbsp
                            <div><a href="Shop.aspx" class="btn btn-warning py-3 px-4">Continue Shopping</a></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row justify-content-end">
                <div class="col col-lg-3 col-md-6 mt-5 cart-wrap ftco-animate">
                    <div class="cart-total mb-3" id="totalcart" runat="server">
                    </div>
                    <p class="text-center"><a href="CheckOut.aspx" class="btn btn-warning py-3 px-4">Proceed to Checkout</a></p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

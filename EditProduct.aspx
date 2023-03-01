<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Kota_FrontEnd.EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="food-area section-padding">
        <div class="container">
            <div class="row">
                <div class="col-md-5">
                    <div class="section-top">
                        <h3><span class="style-change">Select Product to Update</span></h3>
                    </div>
                </div>
            </div>
            <div class="row" id="prod" runat="server">
            </div>
        </div>
    </section>
</asp:Content>

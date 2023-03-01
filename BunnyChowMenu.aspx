<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="BunnyChowMenu.aspx.cs" Inherits="Kota_FrontEnd.BunnyChowMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner-area  menu-bg text-center">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="mb-3 mt-5 bread">Our Bunny Chow Menu</h1>
                    <p class="pt-2"><i>Beast kind form divide night above let moveth bearing darkness.</i></p>
                </div>
            </div>
        </div>
    </section>

    <section class="food-area section-padding">
        <div class="container">
            <div class="row" id="bunny" runat="server">
            </div>
        </div>
    </section>
</asp:Content>

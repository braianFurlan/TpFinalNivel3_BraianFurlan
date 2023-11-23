﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Pagina principal de Articulos</h1>


    <div class ="row row-cols-1 row-cols-md-3 g-4">


  
        
    
    <asp:Repeater ID="Repeater1" runat="server">
          <ItemTemplate>

               <div class="col">
         <div class="card">
      <img src="<%#Eval ("url_imagen") %>"   class="card-img-top" Style="max-width:500px;max-height:600px"; alt="..."onerror="this.src='https://www.mansor.com.uy/wp-content/uploads/2020/06/imagen-no-disponible2.jpg'">
      <div class="card-body">
             <h5 class="card-title"><%#Eval("nombre")  %></h5>
             <p class="card-text"><%#Eval("descripcion") %></p>
             <a href="DetalleArticulo.aspx?id=<%#Eval ("Id") %>">Ver detalle</a>
              </div>
           </div>
        </div>



        </ItemTemplate>

    </asp:Repeater>

</asp:Content>

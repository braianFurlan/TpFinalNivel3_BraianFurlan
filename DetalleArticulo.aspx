<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Detalle del articulo seleccionado</h2>
    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label for="txtId" class="form-label">id</label>
                <asp:TextBox runat="server" ID="txtId" class="form-control" />

            </div>
            <div class="mb-3">
                <label for="txtCodigoArticulo" class="form-label">Codigo Articulo</label>
                <asp:TextBox runat="server" ID="txtCodigoArticulo" class="form-control" />
            </div>
            <div>
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="txtMarca" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtCategoria" class="form-label">Categoria</label>
                <asp:DropDownList ID="txtCategoria" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>

            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" class="form-control" />
            </div>

            <div class="mb-3">





               
                <a href="Default.aspx">Volver</a>

            </div>
        </div>




        <div class="col-6">

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtUrlImagen" class="form-label">Url Imagen</label>
                <asp:TextBox runat="server" ID="txtImagenurl" CssClass="form-control" AutoPostBack="true" OnTextChanged ="txtImagenurl_TextChanged" />      
                <asp:Image ImageUrl="https://royaltekitaly.com/articulos/imagenes/no-disponible.png"
                    runat="server" ID="imgArticulo" Width="60%" />

            </div>


        </div>

    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label for="txtId" class="form-label">id</label>
                <asp:TextBox runat="server" ID="txtId" class="form-control" />

            </div>
            <div class="mb-3">
                <label for="txtCodigoArticulo" class="form-label">Codigo Articulo</label>
                <asp:TextBox runat="server" ID="txtCodigoArticulo" class="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="Establesca un codigo" ControlToValidate="txtCodigoArticulo" runat="server" />
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
                <asp:TextBox runat="server" ID="txtPrecio" class="form-control" TextMode="Number" />
                <asp:RequiredFieldValidator ErrorMessage="Precio requerido" ControlToValidate="txtPrecio" runat="server" />
            </div>

            <div class="mb-3">

                
                    

                    
                <asp:Button Text="Aceptar" ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" />
                <a href="Lista articulos.aspx">Cancelar</a>
             
        </div>
    </div>




    <div class="col-6">

        <div class="mb-3">
            <label for="txtDescripcion" class="form-label">Descripcion</label>
            <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" class="form-control" />
        </div>
        <div class="mb-3">
            <label for="txtUrlImagen" class="form-label">Url Imagen</label>
            <asp:TextBox runat="server" ID="txtUrlimagen" class="form-control"
                AutoPosback="true" OnTextChanged="txtUrlimagen_TextChanged" />
            <asp:Image ImageUrl="https://royaltekitaly.com/articulos/imagenes/no-disponible.png"
                runat="server" ID="imgArticulo" Width="60%" />

        </div>


    </div>

    </div>

    <div class="row">
        <div class="col-6">
            <asp:ScriptManager runat="server" />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="mb-3">

                        <%if ((Request.QueryString["id"] != null))
                            {%>
                             <asp:Button Text="Eliminar" ID="Button1" OnClick="btnEliminar_Click" CssClass="btn btn-danger" runat="server" />
                           <% } %>
                        

                    </div>
                    <%if (confirmaEliminacion)
                        { %>
    <div class="mb-3">

                        <div class="mb-3">
                            <asp:CheckBox Text="Confirmar eliminacion" ID="ChConfirmarEliminar" runat="server" />
                            <asp:Button Text="Eliminar" ID="btnConfirmarEliminacion" OnClick="btnConfirmarEliminacion_Click" CssClass="btn btn-outline-danger" runat="server" />

                     </div>


                        <% } %>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>

    </div>
</asp:Content>

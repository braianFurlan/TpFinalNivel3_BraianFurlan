<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lista articulos.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista Articulos</h1>

    <asp:Label Text="filtro" runat="server" />





    <asp:TextBox runat="server" ID="filtro" AutoPostBack="true" OnTextChanged="filtro_TextChanged" />
    <asp:CheckBox runat="server" Text="Filtro Avanzado" CssClass=""
        ID="chkFiltroAvanzado" AutoPostBack="true" OnCheckedChanged="chkFiltroAvanzado_CheckedChanged" />
    <asp:Button Text="Limpiar" runat="server" ID="btnLimpiarFiltroRapido" CssClass="btn btn-primary" OnClick="btnLimpiarFiltroRapido_Click" />

    <% if (filtroAvanzado)
        { %>




        <div class="row">
          <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Campo" ID="lblCampo" runat="server" />
                <asp:DropDownList runat="server" CssClass="form-control" AutoPostBack="true" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                    <asp:ListItem Text="Codigo" />
                    <asp:ListItem Text="Precio" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Criterio" ID="lblCriterio" runat="server" AutoPostback="true" />
                <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ErrorMessage="seleccione criterio" ControlToValidate="ddlCriterio" runat="server" />
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Filtro" runat="server" />
                <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="Ingrese la consulta" ControlToValidate="txtFiltroAvanzado" runat="server" ValidationGroup="ValidacionGeneral" />
            </div>
        </div>
         </div>
          <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-primary" ValidationGroup="ValidacionGeneral" OnClick="btnBuscar_Click" />
                <asp:Button Text="Limpiar" runat="server" ID="btnLimpiar" CssClass="btn btn-primary" OnClick="btnLimpiar_Click" />
            </div>
        </div>
        <% } %>
    </div>

    <asp:GridView ID="dgvArticulo" runat="server" DataKeyNames="Id" OnSelectedIndexChanged="dgvArticulo_SelectedIndexChanged" CssClass="table table-bordered" AutoGenerateColumns="false">
        <Columns>






            <asp:BoundField HeaderText="Codigo" DataField="codigoArticulo" />
            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
            <asp:BoundField HeaderText="Marca" DataField="marca" />
            <asp:BoundField HeaderText="Categoria" DataField="categoria" />
            <asp:BoundField HeaderText="Precio" DataField="precio" />
            <asp:CommandField ShowSelectButton="true" SelectText="🛠️" HeaderText="Modificar" />


            


        </Columns>
    </asp:GridView>
   
    <a href="Formulario.aspx">Agregar</a>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Mi_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Mi Perfil</h1>

    <div class="row">
        <div class="col md-4">
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox ID="txtEmailPerfil" CssClass="form-control" runat="server" TextMode="Email" />


            </div>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox ID="TxtNombrePerfil" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ErrorMessage="Nombre Requerido" ControlToValidate="TxtNombrePerfil" runat="server" />

            </div>
            <div class="mb-3">
                <label class="form-label">Apellido</label>
                <asp:TextBox ID="TxtApellidoPerfil" CssClass="form-control" runat="server" />
                <asp:RequiredFieldValidator ErrorMessage="Apellido Requerido" ControlToValidate="TxtApellidoPerfil" runat="server" />

            </div>
            <div class="mb-3">
                
                

            </div>
            </div>

            <div class="col md-4">
                <label class="form-label">Imagen Perfil</label>
                <input type="file" id="txtImagenPerfil" runat="server" class="form-control" />
                <asp:Image ID="Image1" ImageUrl="https://us.123rf.com/450wm/get4net/get4net1902/get4net190209043/125446708-usuario-an%C3%B3nimo-sin-rostro.jpg" CssClass="img-fluid mb-3" runat="server" />


            </div>
            
        </div>

    <div class="row">
        <div class ="md-4">
            <asp:Button Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" ID="btnGuardar" runat="server" />
            <a href="/">Regresar</a>
        </div>

    </div>

    
</asp:Content>

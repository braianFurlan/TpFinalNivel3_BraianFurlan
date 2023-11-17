<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Crea tu perfil Trainee</h1>

    <div class ="row">
    <div class ="col-2">

        <div class ="col">
            <div class ="mb-3">
                <label class ="form-label"> Email</label>
                <asp:TextBox runat="server" TextMode="Email" ID="TxtEmail" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="Email requerido" ControlToValidate="txtEmail" runat="server" />
            </div>
            <div class="mb-3">
                <label class ="form-label"> Contraseña</label>
                <asp:TextBox runat="server" TextMode="Password" ID="TxtContraseña" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="Email requerido" ControlToValidate="TxtContraseña" runat="server" />
            </div>
            
            

        </div>
        <div class="mb-3">
          
            <asp:Button Text="Registrate" ID="btnRegistro" CssClass="btn btn-primary" OnClick="btnRegistro_Click"  runat="server" />
            <a href="Default.aspx">Cancelar</a>
        </div>

    </div>
</div>

    

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login</h2>

    
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email address</label>
                <asp:TextBox AutoCompleteType="Email" runat="server"  CssClass="form-control" TextMode="Email" ID="txtEmail" />
                <asp:RequiredFieldValidator ErrorMessage="Email requerido" ControlToValidate="txtEmail" runat="server" />
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                <asp:TextBox runat="server" ID="txtpass"  CssClass="form-control" Type="password" />
                <asp:RequiredFieldValidator ErrorMessage="Contraseña requerida" ControlToValidate="txtpass" runat="server" />
            </div>
            <div class="mb-3 form-check">
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnIngresar_Click" runat="server" />
        </div>
        <div class="col-2"></div>
    </div>

</asp:Content>

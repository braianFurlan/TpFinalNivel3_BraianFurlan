<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="TpFinalNivel3_BraianFurlan.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="row">
        <div class ="col-2">

            <div class ="col">
                <div class ="mb-3">
                    <label class ="form-label"> Email</label>
                    <asp:TextBox runat="server" ID="TxtEmail" CssClass="form-control" TextMode="Email" />
                    <asp:RequiredFieldValidator ErrorMessage="Email Requerido" ControlToValidate="TxtEmail" runat="server" />
                </div>
                <div class="mb-3">
                    <label class ="form-label"> Asunto</label>
                    <asp:TextBox runat="server" ID="TxtAsunto" CssClass="form-control" />
                </div>
                <div class="mb-3"> 
                    <label class="form-label">Mensaje</label>
                    <asp:TextBox TextMode="MultiLine" runat="server" CssClass="form-control" ID="TxtMensaje" />
                    <asp:RequiredFieldValidator ErrorMessage="Mensaje requerido" ControlToValidate="TxtMensaje" runat="server" />
                </div>
                

            </div>
            <div class="mb-3">
              
                <asp:Button Text="Enviar" ID="btnEnviar" CssClass="btn btn-primary" OnClick ="btnEnviar_Click" runat="server" />
            </div>

        </div>
    </div>



</asp:Content>

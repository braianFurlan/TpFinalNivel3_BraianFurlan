using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArticuloNegocio;
using ClassLibrary1;
using Dominio;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImgPerfil.ImageUrl = "https://objetivoligar.com/wp-content/uploads/2017/03/blank-profile-picture-973460_1280-768x768.jpg";
            if (!(Page is Login || Page is Default || Page is Registro || Page is error || Page is DetalleArticulo ))
            {
                if (!Seguridad.sessionActiva(Session["trainee"]))
                {
                   
                    Response.Redirect("login.aspx", false);
                }
                else
                {
                    Trainee user = (Trainee)Session["trainee"];
                    lblUsuario.Text = user.Email;
                    if (!string.IsNullOrEmpty(user.ImagenPerfil) )
                    {
                        ImgPerfil.ImageUrl = "~/Images/" + user.ImagenPerfil;
                    }
                } 
                  
            }

            
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx", false);
        }
    }
}
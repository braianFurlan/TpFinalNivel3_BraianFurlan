using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using Dominio;
using ArticuloNegocio;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class Mi_Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Seguridad.sessionActiva(Session["trainee"]))
                    {
                        Trainee user = (Trainee)Session["trainee"];
                        txtEmailPerfil.Text = user.Email;
                        txtEmailPerfil.ReadOnly = true;
                        TxtApellidoPerfil.Text = user.Apellido;
                        TxtNombrePerfil.Text = user.Nombre;
                        if (!string.IsNullOrEmpty(user.ImagenPerfil))
                        {
                            Image1.ImageUrl = "~/Images/" + user.ImagenPerfil + "?v=" + DateTime.Now.Ticks.ToString();
                        }

                       
                    }
                }
                


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx");
            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Page.Validate();
                if (!Page.IsValid)
                {
                    return;
                }

                TraineeNegocio negocio = new TraineeNegocio();
                

                

                Trainee user = (Trainee)Session["trainee"];

                if (txtImagenPerfil.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/");

                    txtImagenPerfil.PostedFile.SaveAs(ruta + "perfil-" + user.Id + ".jpg");
                    user.ImagenPerfil = "perfil-" + user.Id + ".jpg";
                }
                

               

                user.Nombre = TxtNombrePerfil.Text;
                user.Apellido = TxtApellidoPerfil.Text;
                
                negocio.actualizar(user);
                Image img = (Image)Master.FindControl("ImgPerfil");
                img.ImageUrl = "~/Images/" + user.ImagenPerfil + "?v=" + DateTime.Now.Ticks.ToString();



            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx", false);
            }
        }



    }

        

    
}
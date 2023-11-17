
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using ArticuloNegocio;
using ClassLibrary1;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static bool esAdmin(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            return usuario != null ? usuario.tipouser : false;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Trainee trainee = new Trainee();
            TraineeNegocio negocio = new TraineeNegocio();


            try
            {
                

                trainee.Email = txtEmail.Text;
                trainee.Pass = txtpass.Text;
                if (negocio.login(trainee))
                {
                    Session.Add("trainee", trainee);
                    Response.Redirect("MiPerfil.aspx", false);

                }
                else
                {
                    Session.Add("error", "user o pass incorrectos");
                    Response.Redirect("error.aspx", false);
                }
                

            }
            catch(System.Threading.ThreadAbortException ex) { }
            catch (Exception ex)
            {


                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx");
            }
        }
        
    }
}
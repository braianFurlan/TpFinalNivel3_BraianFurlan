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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee trainee = new Trainee();
                EmailServices emailServices = new EmailServices();  
                TraineeNegocio negocio = new TraineeNegocio();
                trainee.Email = TxtEmail.Text;
                trainee.Pass = TxtContraseña.Text;
                trainee.Id = negocio.insertarNuevo(trainee);
                Session.Add("trainee", trainee);
                //emailServices.armarCorreo(trainee.Email, "hola"," te damos la bienvenida a la app");
                //emailServices.enviarEmail();
                Response.Redirect("Home.aspx", false);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
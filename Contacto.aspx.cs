using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArticuloNegocio;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailServices emailServices = new ArticuloNegocio.EmailServices ();
            emailServices.armarCorreo(TxtEmail.Text,TxtAsunto.Text,TxtMensaje.Text);
            try
            {
                emailServices.enviarEmail();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
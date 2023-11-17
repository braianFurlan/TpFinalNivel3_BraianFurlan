using ArticuloNegocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArticuloNegocio;
using Dominio;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class Default : System.Web.UI.Page
    {

        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            ListaArticulos = negocio.listar();
            
            
            if(!IsPostBack)
            {
                Repeater1.DataSource = ListaArticulos;
                Repeater1.DataBind();
            }
            
        }




        

            
}
}
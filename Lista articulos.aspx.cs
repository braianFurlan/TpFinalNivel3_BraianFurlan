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
    public partial class Detalles : System.Web.UI.Page
    {
        public bool filtroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Seguridad.esAdmin(Session["trainee"]))
            {
                Session.Add("error", "Se requieren permisos de admin para acceder a esta pantalla.");
                Response.Redirect("Error.aspx",false);
            }

            //if (Session["usuario"] == null)
            //{
            //    Session.Add("error", "debes logearte para ingresar a la lista");
            //    Response.Redirect("error.aspx",false);
            // }
            filtroAvanzado = chkFiltroAvanzado.Checked;
            if (!IsPostBack)
            {

            
              
              Negocio negocio = new Negocio();
              Session.Add("listaArticulos", negocio.listar());
              dgvArticulo.DataSource = Session["listaArticulos"];
              dgvArticulo.DataBind();
            }
        }

        protected void dgvArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = dgvArticulo.SelectedRow.Cells[0].Text;
            var id = dgvArticulo.SelectedDataKey.Value.ToString();
            Response.Redirect("formulario.aspx?id=" + id);
        }

        protected void filtro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>) Session["listaArticulos"];
            List<Articulo> listaFiltrada = lista.FindAll( x => x.nombre.ToUpper().Contains(filtro.Text.ToUpper())); 
            dgvArticulo.DataSource= listaFiltrada;
            dgvArticulo.DataBind();
        }

        protected void chkFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            filtroAvanzado = chkFiltroAvanzado.Checked;
            filtro.Enabled = !filtroAvanzado;
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlCriterio.Items.Clear();
            if (ddlCampo.SelectedItem.ToString() == "Precio")
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Mayor a");
                ddlCriterio.Items.Add("Menor a");

            }
            else
            {
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Comienza con");
                ddlCriterio.Items.Add("Termina con");

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio negocio = new Negocio();
                dgvArticulo.DataSource = negocio.filtrar(ddlCampo.SelectedItem.ToString(), ddlCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text);
                dgvArticulo.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx");
            }
        }
    }
}
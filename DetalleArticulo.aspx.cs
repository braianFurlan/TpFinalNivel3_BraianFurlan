using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArticuloNegocio;
using Dominio; 

namespace TpFinalNivel3_BraianFurlan
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                
                if (!IsPostBack)
                {
                    CategoriaNegocio negocioc = new CategoriaNegocio();
                    //List<CATEGORIA> lista = negocioc.listar();
                    MarcaNegocio negociom = new MarcaNegocio();
                    txtCategoria.DataSource = negocioc.listar();
                    txtCategoria.DataValueField = "id";
                    txtCategoria.DataTextField = "descripcion";
                    txtCategoria.DataBind();


                    txtMarca.DataSource = negociom.listar();
                    txtMarca.DataValueField = "id";
                    txtMarca.DataTextField = "descripcion";
                    txtMarca.DataBind();




                }
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    Negocio negocio = new Negocio();
                    Articulo seleccionado = (negocio.listar(id))[0];


                    txtId.Text = id;
                    txtId.ReadOnly = true;
                    txtCodigoArticulo.Text = seleccionado.codigoArticulo;
                    txtCodigoArticulo.ReadOnly = true;
                    txtNombre.Text = seleccionado.nombre;
                    txtNombre.ReadOnly = true;
                    txtDescripcion.Text = seleccionado.descripcion;
                    txtDescripcion.ReadOnly = true;
                    txtImagenurl.Text = seleccionado.url_imagen;
                    txtImagenurl.ReadOnly = true;
                    txtMarca.SelectedValue = seleccionado.marca.id.ToString();
                    txtCategoria.SelectedValue = seleccionado.categoria.id.ToString();
                    txtCategoria.Enabled = false; 
                    txtMarca.Enabled = false;
                    txtPrecio.Text = seleccionado.precio.ToString();
                    txtPrecio.ReadOnly = true;
                    
                    txtImagenurl_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("error.aspx" );
            }
        }

        protected void txtImagenurl_TextChanged(object sender, EventArgs e)
        {
          
            imgArticulo.ImageUrl = txtImagenurl.Text;
        }
    }
    
}
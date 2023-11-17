using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArticuloNegocio;
using Dominio;

namespace TpFinalNivel3_BraianFurlan
{
    public partial class formulario : System.Web.UI.Page
    {
        public bool confirmaEliminacion  { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!ArticuloNegocio.Seguridad.esAdmin(Session["trainee"]))
            {
                Session.Add("error", "no tienes permiso de admin");
                Response.Redirect("error.aspx", false);
            }


            

            confirmaEliminacion = false;
            txtId.Enabled = false;
            
            try
            {
                CategoriaNegocio negocioc = new CategoriaNegocio();
                //List<CATEGORIA> lista = negocioc.listar();
                MarcaNegocio negociom = new MarcaNegocio();
                if (!IsPostBack)
                {

                    txtCategoria.DataSource = negocioc.listar();
                    txtCategoria.DataValueField = "id";
                    txtCategoria.DataTextField = "descripcion";
                    txtCategoria.DataBind();
                   
                   
                    txtMarca.DataSource = negociom.listar();
                    txtMarca.DataValueField = "id";
                    txtMarca.DataTextField = "descripcion";
                    txtMarca.DataBind();
                   

                   


                }
                string id = (Request.QueryString["id"] != null) ? Request.QueryString["id"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    Negocio negocio = new Negocio();
                    Articulo seleccionado = (negocio.listar(id))[0];


                    txtId.Text = id;
                    txtCodigoArticulo.Text = seleccionado.codigoArticulo;
                    txtNombre.Text = seleccionado.nombre;
                    txtDescripcion.Text = seleccionado.descripcion;
                    txtUrlimagen.Text = seleccionado.url_imagen;
                    txtMarca.SelectedValue = seleccionado.marca.id.ToString();
                    txtCategoria.SelectedValue = seleccionado.categoria.id.ToString();
                    txtPrecio.Text = seleccionado.precio.ToString();
                    CargarImagen();

                }
            }
            catch (Exception ex)
            {

              Session.Add("error",ex);
                Response.Redirect("error.aspx", false);
            }
            

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo a = new Articulo();
                Negocio negocio = new Negocio();
                

               // a.Id = int.Parse(txtId.Text);
                a.nombre = txtNombre.Text;
                a.codigoArticulo = txtCodigoArticulo.Text;
                a.descripcion = txtDescripcion.Text;
                a.url_imagen = txtUrlimagen.Text;
                a.precio = decimal.Parse(txtPrecio.Text);


                a.marca = new MARCA();
                a.marca.id = int.Parse(txtMarca.SelectedValue);

                a.categoria = new CATEGORIA();
                a.categoria.id = int.Parse(txtCategoria.SelectedValue);


                if (Request.QueryString ["id"] != null)
                {
                    a.Id= int.Parse(txtId.Text);
                    negocio.modificarConSp(a);
                }
                else
                {
                    negocio.agregarConSp(a);
                }

                
                Response.Redirect("Default.aspx",false);




            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx",false);
            }

        }

        protected void txtUrlimagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen();
        }


        public void CargarImagen()
        {
            imgArticulo.ImageUrl = txtUrlimagen.Text;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmaEliminacion = true;
        }

        protected void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (ChConfirmarEliminar.Checked)
                {
                    Negocio negocio = new Negocio();
                    negocio.eliminar(int.Parse(txtId.Text));
                    Response.Redirect("Default.aspx",false);
                }
                
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("error.aspx", false);
            }
        }
    }


        

}
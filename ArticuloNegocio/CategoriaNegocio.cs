using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace ArticuloNegocio
{
    public class CategoriaNegocio
    {
        public List<CATEGORIA> listar()
        {
            List<CATEGORIA> lista = new List<CATEGORIA>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select id, descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    CATEGORIA aux = new CATEGORIA();
                    aux.id = (int)datos.Lector["id"];
                    aux.descripcion = (string)datos.Lector["descripcion"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        
        



    }
}

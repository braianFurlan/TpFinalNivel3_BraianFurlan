using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Configuration;

namespace ArticuloNegocio
{
    public class MarcaNegocio
    {
        public List<MARCA> listar()
        {
			List<MARCA> lista = new List<MARCA>();
			AccesoDatos datos = new AccesoDatos(); 
			
			try
			{
				datos.setearConsulta("select id, descripcion from MARCAS");
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					MARCA aux = new MARCA();
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

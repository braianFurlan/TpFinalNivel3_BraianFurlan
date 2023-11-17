using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using ArticuloNegocio;
using System.Diagnostics.Eventing.Reader;

namespace ArticuloNegocio
{
     public class UsuarioNegocio
    {
		
        public bool logear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
			{
				
				datos.setearConsulta("select Id, admin from USERS where @email = email and @pass = pass ");
				datos.setearParametro("@email", usuario.User);
				datos.setearParametro("@pass", usuario.Pass);
				datos.ejecutarLectura();
				if (datos.Lector.Read()) {
					usuario.id = (int)datos.Lector["id"];
					usuario.tipouser = (bool)datos.Lector["admin"];
					//usuario.tipouser = (bool) (datos.Lector["admin"]) == 0 ? TipoUsuario.NORMAL : TipoUsuario.ADMIN;
					return true;

				}
				return false;
			}
			catch (Exception ex)
			{

				throw ex;
				
			}
			
			
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Dominio;

namespace ArticuloNegocio
{
    public class TraineeNegocio
    {
        public void actualizar(Trainee user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update USERS set urlImagenPerfil = @imagen, Nombre = @nombre,Apellido = @apellido where Id = @id" );
                datos.setearParametro("@imagen", user.ImagenPerfil != null ? user.ImagenPerfil : "");
                datos.setearParametro("@id", user.Id);
                datos.setearParametro("@apellido", user.Apellido);
                datos.setearParametro("@nombre", user.Nombre);
                

                datos.ejecutarAccion();

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

        public int insertarNuevo(Trainee nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("insertarNuevo");
                datos.setearParametro("@email", nuevo.Email);
                datos.setearParametro("@pass", nuevo.Pass);
                return datos.ejecutarAccionScalar();





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

        public bool login(Trainee trainee)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select id, email, pass, nombre, apellido, urlImagenPerfil, admin from USERS where email = @email and pass = @pass");
                datos.setearParametro("@email", trainee.Email);
                datos.setearParametro("@pass", trainee.Pass);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    trainee.Id = (int)datos.Lector["id"];
                    trainee.Admin = (bool)datos.Lector["admin"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        trainee.Nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                        trainee.Apellido = (string)datos.Lector["apellido"];
                    if (!(datos.Lector["urlImagenPerfil"] is DBNull))
                        trainee.ImagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}

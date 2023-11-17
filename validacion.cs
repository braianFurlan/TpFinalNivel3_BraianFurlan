using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticuloNegocio
{
     public static class validacion
    {
        public static bool validarVacio(Object control)
        {
            if(control is TextBox)
            {
                if (string.IsNullOrEmpty(((TextBox)control).Text))
                    return false;
                else
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}

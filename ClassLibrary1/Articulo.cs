using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Codigo articulo")]
        public string codigoArticulo { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Descripción")]
        public string descripcion { get; set; }
        public string MyProperty { get; set; }
        [DisplayName("Marca")]
        public MARCA marca { get; set; }
        [DisplayName("Categoria")]
        public CATEGORIA categoria { get; set; }
        public string url_imagen { get; set; }
        [DisplayName("Precio")]
        public decimal precio { get; set; }


    }
}

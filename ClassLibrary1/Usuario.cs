using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
        public enum TipoUsuario
   {
           NORMAL = 0,
          ADMIN  = 1,
    }
        public class Usuario
    {
        public Usuario(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            
        }

        public int id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public bool tipouser { get; set; }
    }
}

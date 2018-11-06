using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Usuario
    {
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public Usuario(string nombre,string email,string contraseña)
        {
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.email = email;
        }
    }
}

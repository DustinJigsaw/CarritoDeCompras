using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador:Usuario
    {
        public Administrador(string nombre,string email,string contraseña):base(nombre,email,contraseña)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empresa
    {
        public List<Cliente> clientes { get; set; }
        public List<Producto> productos { get; set; }
        public List<Categoria> categorias { get; set; }
        public List<Administrador> administradores { get; set; }
        public Empresa()
        {
            clientes = new List<Cliente>();
            productos = new List<Producto>();
            categorias = new List<Categoria>();
            administradores = new List<Administrador>();

            categorias.Add(new Categoria { id = 1, nombre = "Almacen", descripcion = "Suena muy feo" });
        }
    }
}

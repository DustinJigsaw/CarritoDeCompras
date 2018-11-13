using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador:Usuario
    {
        Empresa empresa { get; set; }

        public Administrador(string nombre,string email,string contraseña):base(nombre,email,contraseña)
        {
            
        }
        public void agregarCategoria(Categoria unaCategoria)
        {
            empresa.categorias.Add(unaCategoria);
        }
        public void borrarCategoria(Categoria unaCategoria)
        {
            empresa.categorias.Remove(unaCategoria);
        }
        public void agregarProducto(Producto unProducto)
        {
            empresa.productos.Add(unProducto);
        }
        public void borrarProducto(Producto unProducto)
        {
            empresa.productos.Remove(unProducto);
        }   
    }
}

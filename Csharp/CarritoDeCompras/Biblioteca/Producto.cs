using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int codigoBarra { get; set; }
        public double precioUnitario { get; set; }
        public string descripcion { get; set; }
        public Categoria categoria { get; set; }
        public Producto(int id,string nombre,int codigoBarra,double precioUnitario,string descripcion,Categoria categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.codigoBarra = codigoBarra;
            this.precioUnitario=precioUnitario;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }
    }
}

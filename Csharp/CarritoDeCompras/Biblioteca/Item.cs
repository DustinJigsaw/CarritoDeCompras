using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Item
    {
        public int idItem { get; set; }
        public int cantidad { get; set; }

        public Producto producto { get; set; }
        public double precioUnitario { get; set; }
        public double subTotalProducto { get; set; }

        public Item(int id,int cantidad, Producto producto,double precioUnitario,double subTotalProducto)
        {
            this.idItem = id;
            this.cantidad = cantidad;
            this.producto = producto;
            this.precioUnitario = precioUnitario;
            this.subTotalProducto = subTotalProducto;
        }

        public double precioxcantidad()
        {
            subTotalProducto = precioUnitario * cantidad;
            return subTotalProducto;
        }
    }
}

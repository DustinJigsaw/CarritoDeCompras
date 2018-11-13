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
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public double precioUnitario { get; set; }
        public double subTotalProducto { get; set; }

        public Item(int id,int cantidad,int idProducto,string nombreProducto,double precioUnitario,double subTotalProducto)
        {
            this.idItem = id;
            this.cantidad = cantidad;
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
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

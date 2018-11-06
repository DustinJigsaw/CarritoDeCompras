using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carrito
    {
        public List<Item> items { get; set; }

        List<Item> prueba = new List<Item>();
        public int id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaUltMod { get; set; }
        public Carrito(int id,DateTime fechaCreacion,DateTime fechaUltMod)
        {
            this.id = id;
            this.fechaCreacion = fechaCreacion;
            this.fechaUltMod = fechaUltMod;
        }
    }
}

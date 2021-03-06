﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carrito
    {
        public List<Item> items { get; set; }
        public int id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaUltMod { get; set; }
        public Carrito(int id,DateTime fechaCreacion,DateTime fechaUltMod)
        {
            this.id = id;
            this.fechaCreacion = fechaCreacion;
            this.fechaUltMod = fechaUltMod;
            items = new List<Item>();
        }
        public void actualizarItem(Item unItem)
        {
            Item item = items.FirstOrDefault(x => x.idItem == unItem.idItem);
            item.cantidad = unItem.cantidad;
        }
        public void agregarItem(Item unItem)
        {
            items.Add(unItem);
        }
        public void borrarItem(Item unItem)
        {
            items.Remove(unItem);
        }
        public double calcularCosto(Item unItem)
        {
            double precioTotal=items.Sum(x => x.subTotalProducto);
           
            return precioTotal;
        }
         
    }
}

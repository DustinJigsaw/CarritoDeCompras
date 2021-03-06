﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente:Usuario
    {
        public string direccion { get; set; }
        public string telefono{get;set;}
        public int nmrTarjetaCred { get; set; }
        public List<Carrito> carritos { get; set; }
        public Cliente(string nombre, string email,string contraseña, string direccion, string telefono, int nmrTarjetaCred) : base(nombre, email,contraseña)
        {
            this.direccion = direccion;
            this.telefono = telefono;
            this.nmrTarjetaCred = nmrTarjetaCred;
            carritos = new List<Carrito>();
        }
        public void crearCarrito(Carrito unCarrito)
        {
            carritos.Add(unCarrito);
        }
        public void modificarDatos(Cliente unCliente)
        {
            direccion = unCliente.direccion;
            telefono = unCliente.telefono;
            nmrTarjetaCred = unCliente.nmrTarjetaCred;
        }
    }
}

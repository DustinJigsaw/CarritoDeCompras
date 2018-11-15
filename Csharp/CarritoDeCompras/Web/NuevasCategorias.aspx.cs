using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NDatabase;
using Biblioteca;

namespace Web
{
    public partial class NuevaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

            var categoria = new Categoria(Convert.ToInt32(txtId.Text), txtNombre.Text, txtDescripcion.Text);

           var odb = OdbFactory.Open("CarritoDeCompra.db");
           odb.Close();

           odb.Store(categoria);

        }

       

    }
}
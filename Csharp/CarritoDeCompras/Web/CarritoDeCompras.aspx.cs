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
    public partial class CarritoDeCompras : System.Web.UI.Page
    {
        Empresa emp = new Empresa();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlProducto.Items.Clear();
            emp.productos.ForEach(x => ddlProducto.Items.Add(new ListItem(x.nombre, x.id.ToString())));
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lbnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
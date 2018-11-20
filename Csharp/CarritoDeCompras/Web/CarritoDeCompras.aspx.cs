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
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {
                var productos = odb1.QueryAndExecute<Producto>();
                grdproductos.DataSource = productos;
                grdproductos.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {

                var productos = odb1.QueryAndExecute<Productos>();
                //odb1.Close();

                Response.Redirect("CarritoDeCompras.aspx");
            }
        }

        protected void lbnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administradores.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
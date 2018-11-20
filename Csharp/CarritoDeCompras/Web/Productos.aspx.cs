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
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                  
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompras.db"))
            {
                var productos = odb1.QueryAndExecute<Producto>();
                grdProductos.DataSource = productos;
                grdProductos.DataBind();
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            using (var obd = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {
                var productos = obd.QueryAndExecute<Producto>();
                //var art = productos.First();
                //obd.Delete(art);
                grdProductos.DataSource = productos;
                grdProductos.DataBind();
            }
        }

        protected void grdProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
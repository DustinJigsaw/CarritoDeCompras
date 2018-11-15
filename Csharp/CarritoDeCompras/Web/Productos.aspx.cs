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
            using (var odb1 = OdbFactory.Open("C:\\Users\\PC08\\Desktop\\cd\\CarritoDeCompras.db"))
            {
                var productos = odb1.QueryAndExecute<Producto>();
                grdProductos.DataSource = productos;
                grdProductos.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}
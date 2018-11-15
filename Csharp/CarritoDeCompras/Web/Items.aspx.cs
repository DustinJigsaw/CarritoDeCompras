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
    public partial class Items : System.Web.UI.Page
    {
        Empresa emp = new Empresa();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlProducto.Items.Clear();
            emp.productos.ForEach(x => ddlProducto.Items.Add(new ListItem(x.nombre, x.id.ToString())));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubTotal_Click(object sender, EventArgs e)
        {

            int idProducto = Convert.ToInt32(ddlProducto.SelectedValue.ToString());

            Producto unproducto = emp.productos.FirstOrDefault(x => x.id == idProducto);

            var item = new Item(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtCantidad.Text), unproducto, unproducto.precioUnitario, Convert.ToInt32(txtCantidad.Text) * unproducto.precioUnitario);

            var odb = OdbFactory.Open("CarritoDeCompras.db");
      
            odb.Store(item);

            odb.Close();

            var odb1 = OdbFactory.Open("CarritoDeCompras.db");

            var items = odb1.QueryAndExecute<Items>();

            odb1.Close();

            Response.Redirect("CarritoDeCompras.aspx");
        }
    }
}
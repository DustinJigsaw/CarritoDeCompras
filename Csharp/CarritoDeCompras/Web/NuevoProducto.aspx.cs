using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using NDatabase;

namespace Web
{
    public partial class NuevoProducto : System.Web.UI.Page
    {
        Empresa emp = new Empresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlcategoria.Items.Clear();
            emp.categorias.ForEach(x => ddlcategoria.Items.Add(new ListItem(x.nombre, x.id.ToString())));
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(ddlcategoria.SelectedValue);

            Categoria unaCategoria = emp.categorias.FirstOrDefault(x => x.id == idCategoria);

            Producto producto = new Producto(Convert.ToInt32(txtid.Text),txtnom.Text,Convert.ToInt32(txtCodBarra.Text),
                Convert.ToDouble(txtPrecioUni.Text),txtDescripcion.Text, unaCategoria);

            var odb = OdbFactory.Open("C:\\Users\\PC08\\Desktop\\cd\\CarritoDeCompras.db");
                odb.Store(producto);
                odb.Close();
                Response.Redirect("Productos.aspx");
        }
    }
}
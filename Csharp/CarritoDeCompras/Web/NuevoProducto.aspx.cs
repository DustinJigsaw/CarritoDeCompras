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
            //emp.categorias.ForEach(x => ddlcategoria.Items.Add(new ListItem(x.nombre, x.id.ToString())));
   
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {
                var categorias = odb1.QueryAndExecute<Categoria>();
                foreach (var categoria in categorias)
                {
                    ddlcategoria.Items.Add(new ListItem { Value = categoria.id.ToString(), Text = categoria.nombre });
                }
                Response.Redirect("Categorias.aspx");
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(ddlcategoria.SelectedValue);

            //TODO: unicamente debe leer las categorias ingresadas por el usuario, no debe quedar nada hardcodeado
            Categoria unaCategoria = emp.categorias.FirstOrDefault(x => x.id == idCategoria);

            Producto producto = new Producto(Convert.ToInt32(txtid.Text),txtnom.Text,Convert.ToInt32(txtCodBarra.Text),
                Convert.ToDouble(txtPrecioUni.Text),txtDescripcion.Text, unaCategoria);

            using (var odb = OdbFactory.Open("D:\\CarritoDeCompras.db"))
            {
                odb.Store(producto);
            }
             
            Response.Redirect("Productos.aspx");
        }

        protected void ddlcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
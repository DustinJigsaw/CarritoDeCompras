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
            //using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            //{
            //    var categorias = odb1.QueryAndExecute<Categoria>();
            //    grdCategorias.DataSource = categorias;
            //    grdCategorias.DataBind();
            //}
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

            using (var odb = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {
                odb.Store(categoria);
                //odb.Close();
                Response.Redirect("Categorias.aspx");
            }
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtId_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
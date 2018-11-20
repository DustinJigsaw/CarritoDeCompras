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
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {
                var categorias = odb1.QueryAndExecute<Categoria>();
                grdCategorias.DataSource = categorias;
                grdCategorias.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {


        }

        protected void lbnCrearCategoria_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var odb1 = OdbFactory.Open("D:\\CarritoDeCompra.db"))
            {

                var categorias = odb1.QueryAndExecute<Categoria>();
                //odb1.Close();

                Response.Redirect("Categorias.aspx");
            }

            
        }

        protected void lbnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administradores.aspx");
        }
    
    }
}
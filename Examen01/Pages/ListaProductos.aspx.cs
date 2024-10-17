using Examen01.Connection.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen01.Pages
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarListaProductos();
            }
           
        }
        private void cargarListaProductos()
        {

            try
            {
                Productos listaProductos = new Productos();

                gvProductos.DataSource = listaProductos.GetListaProductos();
                gvProductos.DataBind();
            }
            catch (Exception)
            {

                throw;
            }


        }
        protected void gvProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    // Obtener la cantidad y precio unitario de la fila actual
                    var cantidad = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "cantidad"));
                    var precioUnitario = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "precioUnitario"));

                    // Calcular el costo total
                    var costoTotal = cantidad * precioUnitario;

                    // Asignar el valor calculado a la sexta celda (columna "Costo total")
                    e.Row.Cells[5].Text = costoTotal.ToString("N2");

                    // Calcular el estado del producto
                    string estado = cantidad > 0 ? "Disponible" : "No disponible";
                    e.Row.Cells[6].Text = estado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnNuevo_Producto_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearProducto.aspx", false);
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            cargarListaProductos();
        }
    }
}
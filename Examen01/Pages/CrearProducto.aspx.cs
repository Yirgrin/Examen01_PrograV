using Examen01.Connection.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen01.Pages
{
    public partial class CrearProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void crearProducto()
        {

            try
            {
                string nombre = txtNombre.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precioU = Convert.ToDecimal(txtPrecioU.Text);
                DateTime fecha = DateTime.Now;

                Productos productos = new Productos();

                productos.CrearNuevoProducto(nombre, cantidad, precioU, fecha);
            }
            catch (Exception)
            {

                throw;
            }

        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaProductos.aspx", false);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                crearProducto();
                Response.Redirect("Mensaje.aspx", false);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
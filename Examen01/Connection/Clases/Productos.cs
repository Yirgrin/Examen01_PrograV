using Examen01.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Examen01.Connection.Interfaces;

namespace Examen01.Connection.Clases
{
    public class Productos : IProducto
    {
        PV_Examen01Entities entities;

        public int idProducto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int cantidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal precioUnitario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime fechaRegistro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime fechaModificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ObjectResult<spConsultarTodosLosProductos_Result> GetListaProductos()
        {
            try
            {
                entities = new PV_Examen01Entities();
                return entities.spConsultarTodosLosProductos();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void CrearNuevoProducto(string nombre, int cantidad, decimal precioUnitario, DateTime fechaRegistro)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=PV_Examen01;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spCrearProducto", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
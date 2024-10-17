using Examen01.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01.Connection.Interfaces
{
    internal interface IProducto
    {
        int idProducto { get; set; }
        string nombre { get; set; }
        int cantidad { get; set; }
        decimal precioUnitario { get; set; }
        DateTime fechaRegistro { get; set; }
        DateTime fechaModificacion { get; set; }


        ObjectResult<spConsultarTodosLosProductos_Result> GetListaProductos();
        void CrearNuevoProducto(string nombre, int cantidad, decimal precioUnitario, DateTime fechaRegistro);
    }
}

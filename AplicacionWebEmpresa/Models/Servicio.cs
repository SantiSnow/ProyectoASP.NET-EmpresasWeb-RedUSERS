using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionWebEmpresa.Models
{
    public class Servicio
    {
        public Servicio()
        {

        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}

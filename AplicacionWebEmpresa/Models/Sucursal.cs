using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionWebEmpresa.Models
{
    public class Sucursal
    {
        public Sucursal()
        {

        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public int Empleados { get; set; }

    }
}

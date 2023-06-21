using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Proveedores
    {
        [Key]
        public int Ruc { get; set; }

        public string Razon_Social { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Rubro { get; set; }

        public string Observaciones { get; set; }

        public string Informacion_Bancaria { get; set; }

        public string Calificacion { get; set; }
    }

}

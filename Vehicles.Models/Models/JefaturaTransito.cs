using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Models
{
    public class JefaturaTransito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Ciudad CiudadId { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}

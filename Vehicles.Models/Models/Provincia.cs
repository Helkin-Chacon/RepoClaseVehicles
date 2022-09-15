using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Models
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ciudad> Ciudades { get; set; }
    }
}

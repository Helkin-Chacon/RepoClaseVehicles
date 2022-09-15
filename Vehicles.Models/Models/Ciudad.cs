using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Provincia ProvinciaId { get; set; }
        public List<JefaturaTransito> Jefaturas { get; set; }

    }
}

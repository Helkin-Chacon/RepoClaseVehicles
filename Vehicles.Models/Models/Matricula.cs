using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public Propietario PropietarioId { get; set; }
        public Vehiculo VehiculoId { get; set; }
        public JefaturaTransito JefaturaId { get; set; }
        public DateTime Fecha { get; set; }
        public double Costo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class CabFactura
    {
        public int IdFactura { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdCita { get; set; }
        public DateTime? FechaHora { get; set; }
        public double? PrecioTotal { get; set; }
    }
}

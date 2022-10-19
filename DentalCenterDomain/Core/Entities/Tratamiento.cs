using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class Tratamiento
    {
        public int IdTratamiento { get; set; }
        public string? Tipo { get; set; }
        public int? DuracionDias { get; set; }
        public double? Precio { get; set; }
        public string? Descripcion { get; set; }
    }
}

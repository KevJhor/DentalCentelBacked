using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class CabRecetaMedica
    {
        public int IdRecetaMedica { get; set; }
        public string? NombreDeClinica { get; set; }
        public DateTime? Fecha { get; set; }
    }
}

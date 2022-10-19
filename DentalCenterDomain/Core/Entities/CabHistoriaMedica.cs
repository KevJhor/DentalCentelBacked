using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class CabHistoriaMedica
    {
        public int IdHistoriaMedica { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime? FechaDeActualizacion { get; set; }

        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}

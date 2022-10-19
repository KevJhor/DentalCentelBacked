using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdMedico { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaHora { get; set; }

        public virtual CabMedico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}

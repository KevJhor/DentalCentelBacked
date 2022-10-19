﻿using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class Paciente
    {
        public Paciente()
        {
            CabHistoriaMedica = new HashSet<CabHistoriaMedica>();
            Cita = new HashSet<Cita>();
        }

        public int IdPaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        public DateTime? FechaDeNac { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public bool? Frecuente { get; set; }

        public virtual ICollection<CabHistoriaMedica> CabHistoriaMedica { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
    }
}

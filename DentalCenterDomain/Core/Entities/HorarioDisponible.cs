﻿using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class HorarioDisponible
    {
        public int IdMedico { get; set; }
        public DateTime? Dia { get; set; }
        public TimeSpan? HoraIni { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int? Estado { get; set; }

        public virtual CabMedico IdMedicoNavigation { get; set; } = null!;
    }
}

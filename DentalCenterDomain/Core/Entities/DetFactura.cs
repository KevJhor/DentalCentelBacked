﻿using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class DetFactura
    {
        public int IdFactura { get; set; }
        public int? IdTratamiento { get; set; }
        public int? IdRecetaMedica { get; set; }
        public double? Precio { get; set; }

        public virtual CabFactura IdFacturaNavigation { get; set; } = null!;
        public virtual CabRecetaMedica? IdRecetaMedicaNavigation { get; set; }
        public virtual Tratamiento? IdTratamientoNavigation { get; set; }
    }
}

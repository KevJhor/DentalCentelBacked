using System;
using System.Collections.Generic;

namespace DentalCenterDomain.Core.Entities
{
    public partial class PersonalAdm
    {
        public int IdAsistente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        public string? Rol { get; set; }
    }
}

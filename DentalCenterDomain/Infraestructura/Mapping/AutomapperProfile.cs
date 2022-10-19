using AutoMapper;
using DentalCenterDomain.Core.DTOs;
using DentalCenterDomain.Core.Entities;


namespace DentalCenterDomain.Infrastructure.Mapping
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Paciente, PacienteDTO>();
            CreateMap<PacienteDTO, Paciente>();
    
        }
    }
}

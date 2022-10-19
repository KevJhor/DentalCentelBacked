

using DentalCenterDomain.Core.Entities;

namespace DentalCenterDomain.Core.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetPacientes();
        Task<bool> Insert(Paciente paciente);
    }
}
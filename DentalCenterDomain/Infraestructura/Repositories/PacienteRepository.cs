using DentalCenterDomain.Core.Entities;
using DentalCenterDomain.Core.Interfaces;
using DentalCenterDomain.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;


namespace DentalCenterDomain.Infrastructure.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DentalCenterContext _context;
        public PacienteRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            var pacientes = await _context.Paciente.ToListAsync();
            return pacientes;
        }
    

        public async Task<bool> Insert(Paciente paciente)//AñadirPaciente
        {
            await _context.Paciente.AddAsync(paciente);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
    }
}

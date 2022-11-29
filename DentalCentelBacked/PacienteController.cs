using AutoMapper;
using DentalCenterDomain.Core.DTOs;
using DentalCenterDomain.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonBacked
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper mapper;

        public PacienteController(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteRepository = pacienteRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var paciente = await _pacienteRepository.GetPacientes();
            
            var pacienteList = mapper.Map<List<PacienteDTO>>(paciente);


            return Ok(pacienteList);
        }


    }
}

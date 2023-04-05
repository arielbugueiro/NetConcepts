using AutoMapper;
using AutoMapper.DTOs;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper.Controllers
{
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PersonaController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDTO>>> GetAsync()
        {
            return await _context.Personas.Select(p => new PersonaDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Direcciones = p.Direcciones.Select(d => new DireccionDTO { Id = d.Id, Calle = d.Calle, Pais = d.Pais }).ToList()
            }).ToListAsync();
        }

        [HttpGet("projectTo")]
        public async Task<ActionResult<IEnumerable<PersonaDTO>>> GetProjectTo()
        {
            return await _context.Personas.ProjectTo<PersonaDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }


    }
}
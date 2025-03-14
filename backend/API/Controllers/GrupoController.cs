using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public GrupoController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grupos>>> GetAll()
        {
            var items = await _repository.GetAllGruposAsync();
            return Ok(items);
        }

        [HttpGet("{idGrupo}")]
        public async Task<ActionResult<Grupos>> GetById(int idGrupo)
        {
            var item = await _repository.GetGrupoByIdAsync(idGrupo);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Grupos>> Create(Grupos newItem)
        {
            var createdItem = await _repository.CreateGrupoAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idGrupo = createdItem.id_grupo }, createdItem);
        }

        [HttpPut("{idGrupo}")]
        public async Task<IActionResult> Update(int idGrupo, Grupos updatedItem)
        {
            if (idGrupo != updatedItem.id_grupo)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetGrupoByIdAsync(idGrupo);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateGrupoAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idGrupo}")]
        public async Task<IActionResult> Delete(int idGrupo)
        {
            var existingItem = await _repository.GetGrupoByIdAsync(idGrupo);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteGrupoAsync(idGrupo);
            return NoContent();
        }
    }
}

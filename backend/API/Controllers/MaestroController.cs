using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaestroController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public MaestroController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maestros>>> GetAll()
        {
            var items = await _repository.GetAllMaestrosAsync();
            return Ok(items);
        }

        [HttpGet("{idMaestro}")]
        public async Task<ActionResult<Maestros>> GetById(int idMaestro)
        {
            var item = await _repository.GetMaestroByIdAsync(idMaestro);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Maestros>> Create(Maestros newItem)
        {
            var createdItem = await _repository.CreateMaestroAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idMaestro = createdItem.id_maestro }, createdItem);
        }

        [HttpPut("{idMaestro}")]
        public async Task<IActionResult> Update(int idMaestro, Maestros updatedItem)
        {
            if (idMaestro != updatedItem.id_maestro)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetMaestroByIdAsync(idMaestro);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateMaestroAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idMaestro}")]
        public async Task<IActionResult> Delete(int idMaestro)
        {
            var existingItem = await _repository.GetMaestroByIdAsync(idMaestro);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteMaestroAsync(idMaestro);
            return NoContent();
        }

        [HttpDelete("deleteIfExists/{idMaestro}")]
        public async Task<IActionResult> DeleteIfExists(int idMaestro)
        {
            var existingItem = await _repository.GetMaestroByIdAsync(idMaestro);
            if (existingItem != null)
            {
                await _repository.DeleteMaestroAsync(idMaestro);
                return NoContent();
            }
            return NotFound();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradoController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public GradoController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grados>>> GetAll()
        {
            var items = await _repository.GetAllGradosAsync();
            return Ok(items);
        }

        [HttpGet("{idGrado}")]
        public async Task<ActionResult<Grados>> GetById(int idGrado)
        {
            var item = await _repository.GetGradoByIdAsync(idGrado);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Grados>> Create(Grados newItem)
        {
            var createdItem = await _repository.CreateGradoAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idGrados = createdItem.id_grados }, createdItem);
        }

        [HttpPut("{idGrado}")]
        public async Task<IActionResult> Update(int idGrados, Grados updatedItem)
        {
            if (idGrados != updatedItem.id_grados)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetGradoByIdAsync(idGrados);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateGradoAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idGrado}")]
        public async Task<IActionResult> Delete(int idGrado)
        {
            var existingItem = await _repository.GetGradoByIdAsync(idGrado);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteGradoAsync(idGrado);
            return NoContent();
        }
    }
}

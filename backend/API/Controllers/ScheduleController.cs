using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public ScheduleController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horario>>> GetAll()
        {
            var items = await _repository.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id_horario}")]
        public async Task<ActionResult<Horario>> GetById(int id_horario)
        {
            var item = await _repository.GetByIdAsync(id_horario);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Horario>> Create(Horario newItem)
        {
            var createdItem = await _repository.CreateAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { id_horario = createdItem.id_horario }, createdItem);
        }

        [HttpPut("{id_horario}")]
        public async Task<IActionResult> Update(int id_horario, Horario updatedItem)
        {
            if (id_horario != updatedItem.id_horario)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetByIdAsync(id_horario);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{id_horario}")]
        public async Task<IActionResult> Delete(int id_horario)
        {
            var existingItem = await _repository.GetByIdAsync(id_horario);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(id_horario);
            return NoContent();
        }
    }
}

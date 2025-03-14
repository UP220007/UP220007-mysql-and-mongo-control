using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoraInicioController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public HoraInicioController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoraInicio>>> GetAll()
        {
            var items = await _repository.GetAllHoraIniciosAsync();
            return Ok(items);
        }

        [HttpGet("{idInicio}")]
        public async Task<ActionResult<HoraInicio>> GetById(int idInicio)
        {
            var item = await _repository.GetHoraInicioByIdAsync(idInicio);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<HoraInicio>> Create(HoraInicio newItem)
        {
            var createdItem = await _repository.CreateHoraInicioAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idInicio = createdItem.id_inicio }, createdItem);
        }

        [HttpPut("{idInicio}")]
        public async Task<IActionResult> Update(int idInicio, HoraInicio updatedItem)
        {
            if (idInicio != updatedItem.id_inicio)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetHoraInicioByIdAsync(idInicio);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateHoraInicioAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idInicio}")]
        public async Task<IActionResult> Delete(int idInicio)
        {
            var existingItem = await _repository.GetHoraInicioByIdAsync(idInicio);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteHoraInicioAsync(idInicio);
            return NoContent();
        }
    }
}

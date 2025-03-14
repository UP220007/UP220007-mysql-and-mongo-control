using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoraFinController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public HoraFinController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoraFin>>> GetAll()
        {
            var items = await _repository.GetAllHoraFinsAsync();
            return Ok(items);
        }

        [HttpGet("{idFin}")]
        public async Task<ActionResult<HoraFin>> GetById(int idFin)
        {
            var item = await _repository.GetHoraFinByIdAsync(idFin);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<HoraFin>> Create(HoraFin newItem)
        {
            var createdItem = await _repository.CreateHoraFinAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idFin = createdItem.id_fin }, createdItem);
        }

        [HttpPut("{idFin}")]
        public async Task<IActionResult> Update(int idFin, HoraFin updatedItem)
        {
            if (idFin != updatedItem.id_fin)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetHoraFinByIdAsync(idFin);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateHoraFinAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idFin}")]
        public async Task<IActionResult> Delete(int idFin)
        {
            var existingItem = await _repository.GetHoraFinByIdAsync(idFin);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteHoraFinAsync(idFin);
            return NoContent();
        }
    }
}

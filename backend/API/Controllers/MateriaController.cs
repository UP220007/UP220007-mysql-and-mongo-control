using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly IScheduleRepository _repository;

        public MateriaController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materias>>> GetAll()
        {
            var items = await _repository.GetAllMateriasAsync();
            return Ok(items);
        }

        [HttpGet("{idMateria}")]
        public async Task<ActionResult<Materias>> GetById(int idMateria)
        {
            var item = await _repository.GetMateriaByIdAsync(idMateria);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Materias>> Create(Materias newItem)
        {
            var createdItem = await _repository.CreateMateriaAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { idMateria = createdItem.id_materia }, createdItem);
        }

        [HttpPut("{idMateria}")]
        public async Task<IActionResult> Update(int idMateria, Materias updatedItem)
        {
            if (idMateria != updatedItem.id_materia)
            {
                return BadRequest();
            }

            var existingItem = await _repository.GetMateriaByIdAsync(idMateria);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.UpdateMateriaAsync(updatedItem);
            return NoContent();
        }

        [HttpDelete("{idMateria}")]
        public async Task<IActionResult> Delete(int idMateria)
        {
            var existingItem = await _repository.GetMateriaByIdAsync(idMateria);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteMateriaAsync(idMateria);
            return NoContent();
        }
    }
}

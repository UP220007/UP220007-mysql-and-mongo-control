using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FondoHistoricoController : ControllerBase
    {
        private readonly IFondoHistoricoRepository _repository;

        public FondoHistoricoController(IFondoHistoricoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FondoHistorico>>> GetAll([FromQuery] FondoHistoricoQuery query)
        {
            var items = await _repository.GetAllAsync(query);
            return Ok(items);
        }

        [HttpGet("{fhid}")]
        public async Task<ActionResult<FondoHistorico>> GetById(int fhid)
        {
            var item = await _repository.GetByIdAsync(fhid);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<FondoHistorico>> Create(FondoHistoricoDto newItemDto)
        {
            var newItem = new FondoHistorico
            {
                CAJA = newItemDto.CAJA,
                EXP = newItemDto.EXP,
                FOJAS = newItemDto.FOJAS,
                AÑO = newItemDto.AÑO,
                TEMA = newItemDto.TEMA,
                ASUNTO = newItemDto.ASUNTO
            };

            var createdItem = await _repository.CreateAsync(newItem);
            return CreatedAtAction(nameof(GetById), new { fhid = createdItem.FHid }, createdItem);
        }

        [HttpPut("{fhid}")]
        public async Task<IActionResult> Update(int fhid, FondoHistoricoDto updatedItemDto)
        {
            var existingItem = await _repository.GetByIdAsync(fhid);
            if (existingItem == null)
            {
                return NotFound();
            }

            existingItem.CAJA = updatedItemDto.CAJA;
            existingItem.EXP = updatedItemDto.EXP;
            existingItem.FOJAS = updatedItemDto.FOJAS;
            existingItem.AÑO = updatedItemDto.AÑO;
            existingItem.TEMA = updatedItemDto.TEMA;
            existingItem.ASUNTO = updatedItemDto.ASUNTO;

            await _repository.UpdateAsync(existingItem);
            return NoContent();
        }

        [HttpDelete("{fhid}")]
        public async Task<IActionResult> Delete(int fhid)
        {
            var existingItem = await _repository.GetByIdAsync(fhid);
            if (existingItem == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(fhid);
            return NoContent();
        }
    }
}

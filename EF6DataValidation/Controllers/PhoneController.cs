using EF6DataValidation.Data;
using EF6DataValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF6DataValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public PhoneController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> AddPhone([FromBody] Phone phone)
        {
            await _context.Insert(phone);
            return CreatedAtAction(nameof(GetPhone), new { id = phone.Id }, new { });
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetPhone([FromRoute] Guid id)
        {
            var existingPhone = await _context.Get(id);
            if (existingPhone != null)
            {
                return Ok(existingPhone);
            }
            return NotFound();
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult> UpdatePhone([FromBody] Phone phone)
        {
            await _context.Update(phone);
            return Accepted();
        }
    }
}

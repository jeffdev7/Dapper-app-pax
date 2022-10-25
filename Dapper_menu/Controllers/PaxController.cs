using Dapper.menu.Domain.Persistence.Entities;
using Dapper.menu.Domain.Persistence.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Dapper.SqlMapper;

namespace Dapper.menu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaxController : ControllerBase
    {
        private readonly IPaxRepository _paxRepository;

        public PaxController(IPaxRepository paxRepository)
        {
            _paxRepository = paxRepository;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post([FromBody] Pax pax)
        {
            var result = await _paxRepository.AddAsync(pax);
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            var result = await _paxRepository.GetAsync(id);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            await _paxRepository.DeleteAsync(id);
            return Ok();
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Put([FromBody] Pax pax)
        {
            var result = await _paxRepository.Update(pax);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _paxRepository.GetAll();
            return Ok(result);
        }
        [HttpGet("GetGroupOfPax")]
        public async Task<IActionResult> GetPaxAndNumberOfThemAsync()
        {
            var result = await _paxRepository.GetPaxAndNumberOfThemAsync();
            return Ok(result);
        }
        //[HttpGet("GetPaged")]
        //public async Task<IActionResult> GetListPaged(int pageNumber, int rowPerPages, string conditions, string orderby)
        //{
        //    var list = await _paxRepository.GetListPaged(pageNumber, rowPerPages, conditions, orderby);
        //    return Ok(list);
        //}

    }
}

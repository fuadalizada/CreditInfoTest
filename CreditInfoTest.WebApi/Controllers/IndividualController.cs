using CreditInfoTest.DAL.Repositories.Abstract;
using CreditInfoTest.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CreditInfoTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualController : ControllerBase
    {
        private readonly IIndividualRepository _individualRepository;

        public IndividualController(IIndividualRepository individualRepository)
        {
            _individualRepository = individualRepository;
        }


        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Create(Individual individual)
        {
            if (individual != null)
            {
                var result = await _individualRepository.AddAsync(individual);
                if (result is null)
                    return NotFound();
                return new JsonResult(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetAllIndividuals")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllIndividuals()
        {
            var result = await _individualRepository.GetAllAsync();
            if (result is null)
                return NotFound();
            return new JsonResult(result);
        }

        [HttpDelete("Remove")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Remove(Guid id)
        {
            var result = await _individualRepository.DeleteAsync(id);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

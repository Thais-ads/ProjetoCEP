using Microsoft.AspNetCore.Mvc;
using ProjectPilot.Applicantion.Dto;
using ProjectPilot.Applicantion.ServiceInterfaces;
using System.Runtime.InteropServices;

namespace ProjectPilot.Controllers
{

    [ApiController]
    [Route("api/Project/[controller]")]
    public class BuscarCepController : ControllerBase
    {

        private readonly IBuscaCepService _buscaCepService;
         
        public BuscarCepController(IBuscaCepService buscaCep)
        {
            _buscaCepService = buscaCep;
        }

        [HttpGet]
        [Route("BuscaCep")]
        public async Task<IActionResult> BuscaCepAsync([FromBody] string cep)
        {
            RetornoSearchCep retorno = await _buscaCepService.BuscaCep(cep);

            return StatusCode(StatusCodes.Status200OK, retorno);
        }
    }
}

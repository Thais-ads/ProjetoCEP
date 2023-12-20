using Microsoft.AspNetCore.Mvc;
using ProjectPilot.Applicantion.Dto;
using ProjectPilot.Applicantion.ServiceInterfaces;
using System.Runtime.InteropServices;

namespace ProjectPilot.Controllers
{

    [ApiController]
    [Route("api/Project/[controller]")]
    public class ValidaCpfController : ControllerBase
    {

        private readonly IConsultaCpfService _consultaCpfService;
         
        public ValidaCpfController(IConsultaCpfService consultaCpf)
        {
            _consultaCpfService = consultaCpf;
        }

        [HttpGet]   
        [Route("ConsultaCpf")]
        public async Task<IActionResult> BuscaCepAsync( string cpf)
        {
            RetornoCpf retorno = await _consultaCpfService.Validacpf(cpf);

            return StatusCode(StatusCodes.Status200OK, retorno);
        }
    }
}

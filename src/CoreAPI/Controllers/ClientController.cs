using Microsoft.AspNetCore.Mvc;
using ModelDTOs;
using Service;
using System.Threading.Tasks;

namespace CoreAPI.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
               _clientService = clientService;
        }


        [HttpPost]
        public async Task<ActionResult> Create(ClientCreateDto model)
        {
            await _clientService.Create(model);
            return Ok();
        }

    }
}

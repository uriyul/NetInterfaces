using Heqa.BL;
using Heqa.Model;
using Microsoft.AspNetCore.Mvc;

namespace Heqa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfacesController : ControllerBase
    {
        // GET: api/<InterfacesController>
        [HttpGet]
        public List<NetInterface> Get()
        {
            return new GetSystemIps().Get();
        }
    }        
}

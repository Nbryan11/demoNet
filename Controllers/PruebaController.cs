using demo_brayan_api.Modelos;
using demo_brayan_api.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo_brayan_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BrayanDto> getBrayan()
        {
            return new List<BrayanDto>
            {
                 new BrayanDto{Id=1, Nombre="brayan"},
                 new BrayanDto{Id=2, Nombre="pepe"}
            };
        }
    }
}

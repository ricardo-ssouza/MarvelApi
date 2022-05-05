using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [ApiController]
    [Route("api/v1/Hero")]
    public class HeroController
    {
        [HttpGet]
      public string Create()
        {
            return "Teste API";
        }
    }
}

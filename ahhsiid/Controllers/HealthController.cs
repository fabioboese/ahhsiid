using Microsoft.AspNetCore.Mvc;

namespace ahhsiid.Controllers;
[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "It works, Siiiiiiiid!!!";
    }
}

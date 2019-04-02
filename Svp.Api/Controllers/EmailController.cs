namespace Svp.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> SendEmail()
        {
            return "moneypot";
        }
    }
}
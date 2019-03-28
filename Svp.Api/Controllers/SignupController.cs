namespace Svp.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Svp.Api.Controllers.Classes;

    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> Signup([FromBody] SignupRequest request)
        {
            try
            {
                return this.Ok();
            }
            catch (Exception e)
            {
                return this.StatusCode(500);
            }
        }
    }
}
namespace Svp.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Svp.Api.Controllers.Classes;
    using Svp.Services.Interfaces;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : Controller
    {
        private readonly IUserService service;

        public SignupController(IUserService service)
        {
            this.service = service;
        }

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

        //test get --=---=--=--=-=---=--

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return await service.GetUserAsync(id);
        }
    }
}
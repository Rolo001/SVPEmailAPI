namespace Svp.Services.Classes
{
    using Svp.Data.Interfaces;
    using Svp.Services.Interfaces;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly IUserGateway gateway;

        public UserService(IUserGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<string> GetUserAsync(int ID)
        {
            var result = await this.gateway.GetUserDetail(ID);
            return result;
        }
    }
}

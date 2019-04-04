namespace Svp.Services.Classes
{
    using Svp.Data.Interfaces;
    using Svp.Data.Model;
    using Svp.Services.Interfaces;
    using Svp.Services.Models;
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
        public async Task AddUserAsync(SignupRequest request)
        {
            var UserModel = new User()
            {
                Email = request.Email,
                Name = request.Name,
                Password = request.Password
            };
            await gateway.AddUser(UserModel);
        }
    }
}

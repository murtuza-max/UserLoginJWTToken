
using static UserLoginJWTToken.Model.UserLogin;
using UserLoginJWTToken.Model;
using MediatR;
using UserLoginJWTToken.Controllers;

namespace DeleteUser.Controllers
{
    public class UserEndPoint
    {

        public static async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request, IMediator mediator) {
            return await mediator.Send(new RegisterUserCommand.Command {  req = request });
        }
        public static async Task<UserLoginResponse> UserLogin(UserLoginRequest request, IMediator mediator) {
            return await mediator.Send(new UserLoginCommand.Command { req = request });
        }
     
    }
}

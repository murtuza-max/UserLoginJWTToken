using UserLoginJWTToken.Model;
using static UserLoginJWTToken.Model.UserLogin;

namespace UserLoginJWTToken.Repositary
{
    public interface IAuthenticationDataAccess
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);
        Task<UserLoginResponse> UserLogin(UserLoginRequest request);
    }
}
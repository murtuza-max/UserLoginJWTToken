using MediatR;
using static UserLoginJWTToken.Model.UserLogin;
using UserLoginJWTToken.Model;
using UserLoginJWTToken.Repositary;

namespace UserLoginJWTToken.Controllers
{
    public class UserLoginCommand
    {
        public class Command : IRequest<UserLoginResponse>
        {
            public UserLoginRequest req { get; set; }

        }
        public class CommandHandler : IRequestHandler<Command, UserLoginResponse>
        {
            private readonly IAuthenticationDataAccess _repository;

            public CommandHandler(IAuthenticationDataAccess repository)
            {
                _repository = repository;
            }
            public Task<UserLoginResponse> Handle(Command request, CancellationToken cancellationToken)
            {
                //var user = _repository.GetUserByIdAsync(request.Id);
                return _repository.UserLogin(request.req);
            }
        }
    }
}

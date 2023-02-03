using MediatR;
using UserLoginJWTToken.Model;
using UserLoginJWTToken.Repositary;
using static UserLoginJWTToken.Model.UserLogin;

namespace UserLoginJWTToken.Controllers
{
    public class RegisterUserCommand
    {
        public class Command : IRequest<RegisterUserResponse>
        {
            public RegisterUserRequest req { get; set; }
           
        }
        public class CommandHandler : IRequestHandler<Command, RegisterUserResponse>
        {
            private readonly IAuthenticationDataAccess _repository;

            public CommandHandler(IAuthenticationDataAccess repository)
            {
                _repository = repository;
            }
            public Task<RegisterUserResponse> Handle(Command request, CancellationToken cancellationToken)
            {
               
                return _repository.RegisterUser(request.req);
            }
        }
    }
}

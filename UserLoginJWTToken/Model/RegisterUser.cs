

namespace UserLoginJWTToken.Model
{
    public class RegisterUserRequest
    {  
        public string UserName { get; set; }     
        public string Password { get; set; }   
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }

    public class RegisterUserResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
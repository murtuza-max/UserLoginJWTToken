

namespace UserLoginJWTToken.Model
{
    public class UserLogin
    {
        public class UserLoginRequest
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class UserLoginResponse
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public UserLoginInformation data { get; set; }
            public string Token { get; set; }
        }

        public class UserLoginInformation
        {
            public string UserID { get; set; }
            public string UserName { get; set; }
            public string Role { get; set; }
        }
    }
}
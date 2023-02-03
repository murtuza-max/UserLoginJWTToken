

namespace UserLoginJWTToken.Model
{
    public class AddInformationRequest
    {
       
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public int MobileNumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }

    }

    public class AddInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}

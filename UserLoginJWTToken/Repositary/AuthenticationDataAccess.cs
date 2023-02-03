using DeleteUser.Model;
using System.Data.Common;
using UserLoginJWTToken.Model;
using static UserLoginJWTToken.Model.UserLogin;

namespace UserLoginJWTToken.Repositary { 
public class AuthenticationDataAccess : IAuthenticationDataAccess
{
        public readonly IConfiguration _configuration;
        private readonly PostgreSqlContext _context;
       

        public AuthenticationDataAccess(IConfiguration configuration, PostgreSqlContext context)
        {
             _configuration = configuration;
             _context = context;
        }

    public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
    {
        RegisterUserResponse response = new RegisterUserResponse();
        response.IsSuccess = true;
        response.Message = "SuccessFul";
        try
        {
            if (request.Password != request.ConfirmPassword)
            {
                response.IsSuccess = false;
                response.Message = "Password Not Match";
                return response;
            }
                _context.crudapplication.Add(request);
                int Status = await _context.SaveChangesAsync();
                if (Status <= 0)
                {
                    response.IsSuccess = false;
                    response.Message = "Register Query Not Executed";
                    return response;
                }
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
            response.Message = ex.Message;
        }
      
        return response;
    }

    public async Task<UserLoginResponse> UserLogin(UserLoginRequest request)
    {
        UserLoginResponse response = new UserLoginResponse();
        response.IsSuccess = true;
        response.Message = "SuccessFul";

        try
        {
            //    _context.userdetail.Add(request);
            //    int Status = await _context.SaveChangesAsync();

            //    using (MySqlCommand sqlCommand = new MySqlCommand(SqlQuery, _mySqlConnection))
            //{
            //    sqlCommand.CommandType = System.Data.CommandType.Text;
            //    sqlCommand.CommandTimeout = 180;
            //    sqlCommand.Parameters.AddWithValue("@UserName", request.UserName);
            //    sqlCommand.Parameters.AddWithValue("@PassWord", request.Password);
            //    using (DbDataReader dataReader = await sqlCommand.ExecuteReaderAsync())
            //    {
            //        if (dataReader.HasRows)
            //        {
            //            await dataReader.ReadAsync();
            //            response.data = new UserLoginInformation();
            //            response.data.UserID = dataReader["UserId"] != DBNull.Value ? Convert.ToString(dataReader["UserId"]) : string.Empty;
            //            response.data.UserName = dataReader["UserName"] != DBNull.Value ? Convert.ToString(dataReader["UserName"]) : string.Empty;
            //            response.data.Role = dataReader["Role"] != DBNull.Value ? Convert.ToString(dataReader["Role"]) : string.Empty;
            //        }
            //    }

            //}
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
            response.Message = ex.Message;
        }
     
        return response;
    }
  }
}

using FitnessTracker.DTOs;
using FitnessTracker.Model;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace FitnessTracker.Controller
{
    public class UsersController
    {
        private string _BaseURL = "";

        public UsersController()
        {
            _BaseURL = ConfigurationManager.AppSettings.Get("BaseURL");
        }

        public HttpResponseMessage RegisterUser(UserModel user)
        {
            return APIHandler.DoPostXML(_BaseURL + "/user", ref user);
        }

        public APIResponseWrapper<UserModel> AuthenticateUser(string username, string password)
        {
            string hashedPassword = GetSha256Hashed(password);

            LoginRequestDTO logingRequest = new()
            {
                Username = username,
                Password = password
            };

            HttpResponseMessage response = APIHandler.DoPost(_BaseURL + "/user/login", ref logingRequest);

            APIResponseWrapper<UserModel> responseWrapper = new APIResponseWrapper<UserModel>();
            return APIHandler.HandleAPIResponse(response, responseWrapper, false);
        }

        static string GetSha256Hashed(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash).ToLower();
        }
    }
}

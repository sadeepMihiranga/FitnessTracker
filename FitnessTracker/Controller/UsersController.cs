using FitnessTracker.DTOs;
using FitnessTracker.Model;
using FitnessTracker.Repository;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FitnessTracker.Controller
{
    public class UsersController
    {
        public UserModel RegisterUser(UserModel user)
        {
            user.Id = UserRepository.GetNextAvailableId();
            user.Status = Enums.CommonStatusEnum.ACTIVE;
            user.Password = GetSha256Hashed(user.Password);

            UserRepository.Save(user);

            return user;
        }

        public APIResponseWrapper<UserModel> AuthenticateUser(string username, string password)
        {
            string hashedPassword = GetSha256Hashed(password);

            LoginRequestDTO logingRequest = new()
            {
                Username = username,
                Password = password
            };

            HttpResponseMessage response = APIHandler.DoPost("https://everydayfitnessapi.azurewebsites.net/apigateway/v1/user/login", ref logingRequest);

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

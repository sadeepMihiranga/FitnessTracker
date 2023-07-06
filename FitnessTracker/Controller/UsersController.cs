using FitnessTracker.Model;
using FitnessTracker.Repository;
using System.Security.Cryptography;
using System.Text;

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

        public UserModel AuthenticateUser(string username, string password)
        {
            string hashedPassword = GetSha256Hashed(password);
            return UserRepository.FetchUserByUsernameAndPassword(username, hashedPassword); 
        }

        static string GetSha256Hashed(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash).ToLower();
        }
    }
}

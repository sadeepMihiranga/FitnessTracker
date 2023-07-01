using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class UsersController
    {
        public UserModel RegisterUser(UserModel user)
        {
            user.Id = UserRepository.GetNextAvailableId();
            user.Status = Enums.CommonStatusEnum.ACTIVE;

            UserRepository.Save(user);

            return user;
        }
    }
}

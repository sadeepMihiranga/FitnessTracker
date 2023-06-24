using FitnessTracker.Model;
using FitnessTracker.Repository;

namespace FitnessTracker.Controller
{
    internal class UsersController
    {
        public long RegisterUser(UserModel user)
        {
            user.Id = UserRepository.GetNextAvailableId();
            user.Status = Enum.CommonStatusEnum.ACTIVE;

            return UserRepository.Save(user).Id;
        }
    }
}

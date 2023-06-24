using FitnessTracker.Model;
using FitnessTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

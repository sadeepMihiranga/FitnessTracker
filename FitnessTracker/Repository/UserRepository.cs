using FitnessTracker.Model;

namespace FitnessTracker.Repository
{
    internal class UserRepository : BaseRepository
    {
        private static List<UserModel> users = new();
        private static readonly object usersSyncLock = new();

        #region Insert User
        public static UserModel Save(UserModel user)
        {         
            users.Add(user);
            return user;
        }
        #endregion

        #region Get User by Username and Password
        public static UserModel FetchUserByUsernameAndPassword(string username, string password)
        {
            return users
                .Where(u => u.Username.Equals(username))
                .Where(u => u.Password.Equals(password))
                .Where(u => u.Status == Enum.CommonStatusEnum.ACTIVE)
                .First();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (usersSyncLock)
            {
                long newUserId = 1;

                if (!users.Any())
                {
                    return newUserId;
                }

                UserModel userWithMaxId = users.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (userWithMaxId != null)
                {
                    newUserId = userWithMaxId.Id + 1;
                }

                return newUserId;
            }
        }
    }
}

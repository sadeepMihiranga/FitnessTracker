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
                .Where(u => u.Status == Enums.CommonStatusEnum.ACTIVE)
                .FirstOrDefault();
        }
        #endregion

        public static long GetNextAvailableId()
        {
            lock (usersSyncLock)
            {
                long newId = 1;

                if (!users.Any())
                {
                    return newId;
                }

                UserModel userWithMaxId = users.Aggregate((i1, i2) => i1.Id > i2.Id ? i1 : i2);

                if (userWithMaxId != null)
                {
                    newId = userWithMaxId.Id + 1;
                }

                return newId;
            }
        }
    }
}

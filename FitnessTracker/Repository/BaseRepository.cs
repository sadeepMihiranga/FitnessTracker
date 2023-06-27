namespace FitnessTracker.Repository
{
    internal class BaseRepository
    {
        protected static IList<T> GetPage<T>(IList<T> list, int page, int pageSize)
        {
            return list.Skip(page * pageSize).Take(pageSize).ToList();
        }
    }
}

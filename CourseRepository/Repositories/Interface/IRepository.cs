using CourseDomain.Common;

namespace CourseRepository.Repositories.Interface
{
    public interface IRepository<T>where T : BaseEntities
    {
        public void CreateGroup(T data);
        public void UpdateGroup(T data);
        public void DeleteGroup(T data);
        public T GetGroupById(Predicate<T> predicate);
        public List<T> GetAllGroup(Predicate<T> predicate);

    }
}

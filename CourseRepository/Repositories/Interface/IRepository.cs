using CourseDomain.Common;

namespace CourseRepository.Repositories.Interface
{
    public interface IRepository<T>where T : BaseEntities
    {
        public void Create(T data);
        public void Update(T data);
        public void Delete(T data);
        public T GetById(Predicate<T> predicate);
        public List<T> GetAll(Predicate<T> predicate);

    }
}

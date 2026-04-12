using CourseDomain.Entities;
using CourseRepository.Repositories.Interface;

namespace CourseRepository.Repositories.Implementation
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student data)
        {
            throw new NotImplementedException();
        }

        public Student GetById(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Student data)
        {
            throw new NotImplementedException();
        }
    }
}

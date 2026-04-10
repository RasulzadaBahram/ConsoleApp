using CourseDomain.Entities;
using CourseRepository.Repositories.Interface;

namespace CourseRepository.Repositories.Implementation
{
    public class StudentRepository : IRepository<Student>
    {
        public void CreateGroup(Student data)
        {
            throw new NotImplementedException();
        }

        public void DeleteGroup(Student data)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllGroup(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }

        public Student GetGroupById(Predicate<Student> predicate)
        {
            throw new NotImplementedException();
        }

        public void UpdateGroup(Student data)
        {
            throw new NotImplementedException();
        }
    }
}

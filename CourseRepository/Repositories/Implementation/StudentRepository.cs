using CourseDomain.Entities;
using CourseRepository.Data;
using CourseRepository.Repositories.Exceptions;
using CourseRepository.Repositories.Interface;

namespace CourseRepository.Repositories.Implementation
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student data)
        {
            try
            {
                if (data == null)
                {
                    throw new NotFoundException("Data Not Found");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(Student data)
        {
            try
            {
                if (data == null)
                {
                    throw new NotFoundException("Data Not Found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           AppDbContext<Student>.datas.Remove(data);
        }

        public Student Get(Predicate<Student> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Student>.datas.Find(predicate);
            }
            else 
            {
                return null;
            }
        }

        public List<Student> GetAll(Predicate<Student> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Student>.datas.FindAll(predicate);
            }
            else
            {
                return null;
            }
        }

        public void Update(Student data)
        {
            try
            {
                if (data == null) 
                {
                    throw new NotFoundException("Data Not Found");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetAllStudentsByGroupId(int id) 
        {
            List<Student> students = AppDbContext<Student>.datas.FindAll(x => x.Group.Id == id);
            if (students == null) 
            {
                throw new NotFoundException("Data Not Found");
            }
        }
    }
}

using CourseDomain.Entities;
using CourseRepository.Repositories.Implementation;
using CourseService.Services;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

namespace CourseService.Implementations
{
    public class StudentService : IStudentService
    {
        private StudentRepository _studentRepository;
        private static int _count = 1;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public Student CreateStudent(Student student)
        {
            student.Id = _count;
            _studentRepository.Create(student);
            _count++;
            return student;
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.Get(x => x.Id == id);
        }

        public Student UpdateStudent(int id, Student student)
        {
            _studentRepository.Update(student);
            return student;
        }

        public void DeleteStudent(int id)
        {
            Student student = _studentRepository.Get(x => x.Id == id);
            _studentRepository.Delete(student);
        }
        public List<Student> GetAllStudentsByGroupId(int groupId)
        {
            return _studentRepository.GetAll(x => x.Group.Id == groupId);
        }

        public List<Student> GetAllStudentsByAge(int age)
        {
            return _studentRepository.GetAll(x => x.Age == age);
        }
        public List<Student> SearchStudentsByName(string name)
        {
<<<<<<< HEAD
            return _studentRepository.GetAll(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
=======
            return _studentRepository.GetAll(x => x.Name.ToLower().Trim() == name);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        }
    }
}

using CourseDomain.Entities;
<<<<<<< HEAD

namespace CourseService.Services
{
    public interface IStudentService
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseService.Services
{
    internal interface IStudentService
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
    {
        Student CreateStudent(Student student);
        Student UpdateStudent(int id, Student student);
        Student GetStudentById(int id);
<<<<<<< HEAD
        void DeleteStudent(int id);
        List<Student> GetAllStudentsByGroupId(int groupId);
        List<Student> GetAllStudentsByAge(int age);
        List<Student> SearchStudentsByName(string name);
    }
}
=======
        void DeleteStudent(int id); 
    }
}
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

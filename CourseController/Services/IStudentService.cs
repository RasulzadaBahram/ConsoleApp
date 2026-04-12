using CourseDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseService.Services
{
    internal interface IStudentService
    {
        Student CreateStudent(Student student);
        Student UpdateStudent(int id, Student student);
        Student GetStudentById(int id);
    }
}

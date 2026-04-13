using CourseDomain.Entities;

namespace CourseService.Services
{
    public interface IStudentService

    {
        Student CreateStudent(Student student);
        Student UpdateStudent(int id, Student student);
        Student GetStudentById(int id);
        void DeleteStudent(int id);
        List<Student> GetAllStudentsByGroupId(int groupId);
        List<Student> GetAllStudentsByAge(int age);
        List<Student> SearchStudentsByName(string name);
    }
}

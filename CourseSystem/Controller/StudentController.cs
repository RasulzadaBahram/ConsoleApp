using CourseDomain.Entities;
using CourseService.Implementations;
using CourseSystem.Helpers;


namespace CourseSystem.Controller
{
    public class StudentController
    {
        StudentService _studentService = new();
        GroupService _groupService = new();

        public void CreateStudent()
        {
            Helper.PrintConsole(ConsoleColor.Blue, "Name: ");
            string studentName = Console.ReadLine().Trim();
            Helper.PrintConsole(ConsoleColor.Blue, "Surname: ");
            string studentSurname = Console.ReadLine().Trim();
            Helper.PrintConsole(ConsoleColor.Blue, "Age: ");
        StudentAge: string studentAge = Console.ReadLine();

            int age;
            bool isStudentAge = int.TryParse(studentAge, out age);
            if (isStudentAge)
            {
            GroupId: Helper.PrintConsole(ConsoleColor.Blue, "Group: ");
                string StudentGroup = Console.ReadLine();
                int id;
                bool isStudentGroup = int.TryParse(StudentGroup, out id);

                if (isStudentGroup)
                {
                    var group = _groupService.GetGroupById(id);
                    if (group == null)
                    {
                        Helper.PrintConsole(ConsoleColor.Red, "Group Not Found");
                        goto GroupId;
                    }
                    Student student = new Student { Name = studentName, Surname = studentSurname, Age = age, Group = group };
                    student = _studentService.CreateStudent(student);
                    Helper.PrintConsole(ConsoleColor.Green, $"Student Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");



                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Please enter a valid group id number! \n ");
                    goto GroupId;
                }




            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Enter Valid age");
                goto StudentAge;
            }



        }
        public void UpdateStudent()
        {
        studentId: Helper.PrintConsole(ConsoleColor.Blue, "Add Student Id: ");
            string studentId = Console.ReadLine();
            int id;
            bool isstudentId = int.TryParse(studentId, out id);
            if (isstudentId)
            {
                Student student = _studentService.GetStudentById(id);
                if (student != null)
                {
                    Helper.PrintConsole(ConsoleColor.Blue, "Add new Student Name: ");
                    string studentName = Console.ReadLine();
                    Helper.PrintConsole(ConsoleColor.Blue, "Add new Student Surname: ");
                    string studentSurname = Console.ReadLine();
                SelectCase: Helper.PrintConsole(ConsoleColor.Blue, "Add new Student Age: ");
                    string studentAge = Console.ReadLine();
                    int age;
                    bool isStudentAge = int.TryParse(studentAge, out age);
                    if (isStudentAge)
                    {
                        student.Name = studentName;
                        student.Surname = studentSurname;
                        student.Age = age;
                        var result = _studentService.UpdateStudent(id, student);
                        Helper.PrintConsole(ConsoleColor.Green, $"Student Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}\n");
                    }
                    else
                    {
                        Helper.PrintConsole(ConsoleColor.Red, "Please enter a valid number! \n ");
                        goto SelectCase;
                    }
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Student not found \n");
                    goto studentId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct id types: \n ");
                goto studentId;
            }
        }

        public void GetStudentById()
        {
        studentId: Helper.PrintConsole(ConsoleColor.Blue, "Add Student Id: ");
            string studentId = Console.ReadLine();
            int id;
            bool isstudentId = int.TryParse(studentId, out id);
            if (isstudentId)
            {
                Student student = _studentService.GetStudentById(id);
                if (student != null)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Student Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}\n");
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Student not found \n");
                    goto studentId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct id types: \n ");
                goto studentId;
            }
        }

        public void DeleteStudent()
        {
        studentId: Helper.PrintConsole(ConsoleColor.Blue, "Add Student Id: ");
            string studentId = Console.ReadLine();
            int id;
            bool isstudentId = int.TryParse(studentId, out id);
            if (isstudentId)
            {
                Student student = _studentService.GetStudentById(id);
                if (student != null)
                {
                    _studentService.DeleteStudent(id);
                    Helper.PrintConsole(ConsoleColor.Green, "Student deleted successfully \n");
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Student not found \n");
                    goto studentId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct id types: \n ");
                goto studentId;
            }
        }

        public void GetAllStudentsByGroupId()
        {
        groupId: Helper.PrintConsole(ConsoleColor.Blue, "Add Group Id: ");
            string groupId = Console.ReadLine();
            int id;
            bool isgroupId = int.TryParse(groupId, out id);
            if (isgroupId)
            {
                var students = _studentService.GetAllStudentsByGroupId(id);
                if (students != null && students.Count > 0)
                {
                    foreach (var student in students)
                    {
                        Helper.PrintConsole(ConsoleColor.Green, $"Student Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}\n");
                    }
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group not found \n");
                    goto groupId;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct id types: \n ");
                goto groupId;
            }
        }

        public void GetAllStudentsByAge()
        {
        SelectCase: Helper.PrintConsole(ConsoleColor.Blue, "Add Student Age: ");
            string studentAge = Console.ReadLine();
            int age;
            bool isStudentAge = int.TryParse(studentAge, out age);
            if (isStudentAge)
            {
                var students = _studentService.GetAllStudentsByAge(age);
                if (students != null && students.Count > 0)
                {
                    foreach (var student in students)
                    {
                        Helper.PrintConsole(ConsoleColor.Green, $"Student Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}\n");
                    }
                }
                else
                {
                    Helper.PrintConsole(ConsoleColor.Red, "No students found with the specified age \n");
                    goto SelectCase;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Please enter a valid number! \n ");
                goto SelectCase;
            }
        }

        public void SearchStudentsByName()
        {
        SelectCase: Helper.PrintConsole(ConsoleColor.Blue, "Add Student Name: ");
            string studentName = Console.ReadLine().Trim();
            var students = _studentService.SearchStudentsByName(studentName);
            if (students != null && students.Count > 0)
            {
                foreach (var student in students)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Student Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}\n");
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "No students found with the specified name \n");
                goto SelectCase;
            }
        }
    }
}

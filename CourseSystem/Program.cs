using CourseSystem.Controller;
using CourseSystem.Helpers;

namespace CourseSystem;


internal class Program
{
    static void Main(string[] args)
    {
        Helper.PrintConsole(ConsoleColor.Blue, "Select Option:");
        Helper.PrintConsole(ConsoleColor.Yellow, "" +
            "1. Create group\n" +
            "2. Get Group By Id\n" +
            "3. GetAll Group\n" +
            "4. Delete Group\n" +
            "5. Update Group\n" +
            "6. Get All Groups By Teacher\n" +
            "7. Get All Groups By Room Count\n" +
            "8. Create Student\n" +
            "9. Update Student\n" +
            "10. Get Student By Id \n" +
            "11. Delete Student \n" +
            "12. Get All Students By Age\n" +
            "13. Get All Students By Group Id\n" +
            "14. Search Groups By Name\n" +
            "15. Search Students By Name\n");
        GroupController groupController = new();
        StudentController studentController = new();

        while (true)
        {
        SelectOption: string selectedOption = Console.ReadLine();
            int selectNumber;

            bool isSelect = int.TryParse(selectedOption, out selectNumber);
            if (isSelect)
            {
                switch (selectNumber)
                {
                    case 1:
                        groupController.CreateGroup();
                        goto SelectOption;
                    case 2:
                        groupController.GetGroupById();
                        goto SelectOption;
                    case 3:
                        groupController.GetAllGroups();
                        goto SelectOption;
                    case 4:
                        groupController.DeleteGroup();
                        goto SelectOption;
                    case 5:
                        groupController.UpdateGroup();
                        goto SelectOption;
                    case 6:
                        groupController.GetGroupByTeacher();
                        goto SelectOption;
                    case 7:
                        groupController.GetAllGroupByRoom();
                        goto SelectOption;
                    case 8:
                        studentController.CreateStudent();
                        goto SelectOption;
                    case 9:
                        studentController.UpdateStudent();
                        goto SelectOption;
                    case 10:
                        studentController.GetStudentById();
                        goto SelectOption;
                    case 11:
                        studentController.DeleteStudent();
                        goto SelectOption;
                    case 12:
                        studentController.GetAllStudentsByAge();
                        goto SelectOption;
                    case 13:
                        studentController.GetAllStudentsByGroupId();
                        goto SelectOption;
                    //case 14:
                    //    studentController.();
                    //    goto SelectOption;
                    case 15:
                        studentController.SearchStudentsByName();
                        goto SelectOption;

                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Write Correct type of options");
                goto SelectOption;
            }
        }
    }
}

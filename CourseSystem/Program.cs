using CourseDomain.Entities;
using CourseService.Implementations;

namespace CourseSystem.Helpers;


internal class Program
{
    static void Main(string[] args)
    {
        Helper.PrintConsole(ConsoleColor.Blue, "Select Option:");
        Helper.PrintConsole(ConsoleColor.Yellow, "1- CreateGroup \n2- Update Group \n3- Delete Group");

        while (true)
        {
        SelectOption: string selectedOption = Console.ReadLine();
            int selectNumber;

            bool isSelect = int.TryParse(selectedOption, out selectNumber);

            Helper.PrintConsole(ConsoleColor.Blue, $"Group adini daxil edin: ");
            string _group = Console.ReadLine();
            Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Name daxil edin: ");
            string _teacher = Console.ReadLine();
            Helper.PrintConsole(ConsoleColor.Blue, $"Otagin adi: ");
            string _room = Console.ReadLine();
            if (isSelect)
            {
                Group group = new Group {Name=_group,Teacher=_teacher, Room=_room };
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");
                
                switch (selectNumber)
                {
                    case 1:

                        


                        break;
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

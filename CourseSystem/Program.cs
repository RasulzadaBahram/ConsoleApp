using CourseSystem.Controller;
using CourseSystem.Helpers;

namespace CourseSystem;


internal class Program
{
    static void Main(string[] args)
    {
        Helper.PrintConsole(ConsoleColor.Blue, "Select Option:");
        Helper.PrintConsole(ConsoleColor.Yellow, "1- CreateGroup \n2- Update Group \n3- Delete Group");
        GroupController groupController = new ();
        //StudentController studentController = new();

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

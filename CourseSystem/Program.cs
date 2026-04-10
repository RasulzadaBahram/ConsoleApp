namespace CourseSystem.Helpers;

internal class Program
{
    static void Main(string[] args)
    {
        Helper.PrintConsole(ConsoleColor.Blue, "Select Option:");
        Helper.PrintConsole(ConsoleColor.Yellow, "1- CreateGroup \n2- Update Group \n3- Delete Group");

        while (true)
        {
            string selectedoption = Console.ReadLine();
            int selectNumber;

            bool isSelect = int.TryParse(selectedoption, out selectNumber);
            if (isSelect)
            {

                switch (selectNumber)
                {
                    case 1:
                        Helper.PrintConsole(ConsoleColor.Blue, $"Group adini daxil edin: ");
                        string _group=Console.ReadLine();
                        Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Name daxil edin: ");
                        string _teacher=Console.ReadLine();
                        Helper.PrintConsole(ConsoleColor.Blue, $"Otagin adi: ");
                        string _room=Console.ReadLine();




                        break;
                }
            }
        }
    }
}

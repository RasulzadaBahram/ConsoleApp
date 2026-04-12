using CourseDomain.Entities;
using CourseSystem.Helpers;

namespace CourseSystem.Controller
{
    public class GroupController
    {
        Group group = new();
        public void CreateGroup()
        {
            Helper.PrintConsole(ConsoleColor.Blue, $"Group adini daxil edin: ");
            string groupName = Console.ReadLine().Trim();
            Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Name daxil edin: ");
            string teacherName = Console.ReadLine().Trim();
        SelectCase: Helper.PrintConsole(ConsoleColor.Blue, $"Add Group RoomCount: ");
            string groupRoomCount = Console.ReadLine();
            int roomCount;

            bool isRoomCount=int.TryParse( groupRoomCount, out roomCount);
            if (isRoomCount) 
            {
                Group group = new Group { Name = groupName, Teacher = teacherName, Room = roomCount };
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red,"Enter valid RoomCount");
                goto SelectCase;
            }

        }
    }
}

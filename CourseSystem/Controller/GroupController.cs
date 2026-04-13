using CourseDomain.Entities;
using CourseRepository.Repositories.Exceptions;
using CourseService.Implementations;
using CourseSystem.Helpers;

namespace CourseSystem.Controller
{
    public class GroupController
    {
        GroupService _groupService= new();
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
                group=_groupService.CreateGroup(group);
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red,"Enter valid RoomCount");
                goto SelectCase;
            }

        }
        public void GetGroupById() 
        {
        GroupById: Helper.PrintConsole(ConsoleColor.Green, "Add Group Id: ");
            string groupId = Console.ReadLine();
            int id;
            bool isGroup=int.TryParse( groupId, out id);
            if (isGroup)
            {
                Group group=_groupService.GetGroupById(id);
                if (group != null)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id: {group.Id},Name: {group.Name},Teacher: {group.Teacher},Room: {group.Room}");
                }
                else 
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group Not Found");
                    goto GroupById;
                }
            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red, "Group not found\nPlease enter valid id");
                goto GroupById;
            }
        }

        public void GetAllGroups() 
        {
            List<Group> groups = _groupService.GetAllGroups();
            if (groups.Count != 0)
            {
                foreach (Group group in groups)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id: {group.Id},Name: {group.Name},Teacher: {group.Teacher},Room: {group.Room}");
                }
            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red,"There no group available");
            }
        }
        public void UpdateGroup() 
        {

        groupId: Helper.PrintConsole(ConsoleColor.Green, "Add Group Id");
            string groupId=Console.ReadLine();
            int id;
            bool isGroupId=int.TryParse( groupId, out id);
            if (isGroupId)
            {
                Group group = _groupService.GetGroupById(id);
                if (group != null)
                {
                    Helper.PrintConsole(ConsoleColor.Blue, $"Group Yeni adini Daxil Edin: ");
                    string groupName = Console.ReadLine().Trim();
                    Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Yeni Name daxil Edin: ");
                    string teacherName = Console.ReadLine().Trim();
                SelectCase: Helper.PrintConsole(ConsoleColor.Blue, $"Add Group RoomCount: ");
                    string groupRoomCount = Console.ReadLine();
                    int roomCount;

                    bool isRoomCount = int.TryParse(groupRoomCount, out roomCount);
                    if (isRoomCount)
                    {
                        group.Name = groupName;
                        group.Teacher = teacherName;
                        group.Room = roomCount;
                        Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");
                    }
                    else
                    {
                        Helper.PrintConsole(ConsoleColor.Red, "Enter valid RoomCount");
                        goto SelectCase;
                    }
                }
                else 
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group Not Found");
                }

            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add Correct Group Id");
            }
        }
        public void GetGroupByTeacher() 
        {
        groupTeacher: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Teacher Name");
            string teacherName = Console.ReadLine().Trim();
            Group group=_groupService.GetAllGroupByTeacher(teacherName);
            if (group != null)
            {
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");

            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red, $"There is no teacher named: {teacherName}\nEnter correct Teacher Name");
                goto groupTeacher;
            }


        }
        public void GetAllGroupByRoom() 
        {
        groupRoom: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Room");
            string groupRoom = Console.ReadLine().Trim();
            int room;
            bool isGroupRoom=int.TryParse(groupRoom, out room);
            Group group=_groupService.GetAllGroupByRoomCount(room);
            if (group != null)
            {
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");

            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red,$"There is no such room as: {room}");
            }
        }
        public void DeleteGroup() 
        {
        groupId: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Id: ");
            string groupId = Console.ReadLine();
            int id;
            bool isGroupId=int.TryParse(groupId, out id);

            if (isGroupId)
            {
                _groupService.DeleteGroup(id);
                Helper.PrintConsole(ConsoleColor.Green,"Group Succesfully Deleted");
            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red,"Group Not Found\nEnter Valid Id");
                goto groupId;
            }

        }
    }
}

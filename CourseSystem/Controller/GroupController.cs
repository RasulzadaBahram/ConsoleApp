using CourseDomain.Entities;
using CourseRepository.Repositories.Exceptions;
using CourseService.Implementations;
using CourseSystem.Helpers;

namespace CourseSystem.Controller
{
    public class GroupController
    {
<<<<<<< HEAD
        GroupService _groupService = new();
        public void CreateGroup()
        {
            int number;
            int number1;
        GroupName: Helper.PrintConsole(ConsoleColor.Blue, $"Group adini daxil edin: ");
            string groupName = Console.ReadLine().Trim();
            bool isSpaceOrNumber = int.TryParse(groupName, out number);
            if (groupName == null || groupName == "")
            {
                Helper.PrintConsole(ConsoleColor.Red, "Yanlis adlandirma");
                goto GroupName;
            }
            if (isSpaceOrNumber == true)
            {

                Helper.PrintConsole(ConsoleColor.Red, "Yanlis adlandirma");
                goto GroupName;
            }
        TeacherName: Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Name daxil edin: ");
            string teacherName = Console.ReadLine().Trim();
            bool isSpaceOrNumber1 = int.TryParse(teacherName, out number1);
            if (isSpaceOrNumber1 == true)
            {

                Helper.PrintConsole(ConsoleColor.Red, "Yanlis adlandirma");
                goto TeacherName;
            }
            if (teacherName == null || teacherName == "")
            {
                Helper.PrintConsole(ConsoleColor.Red, "Yanlis adlandirma");
                goto TeacherName;
            }
=======
        GroupService _groupService= new();
        public void CreateGroup()
        {
            Helper.PrintConsole(ConsoleColor.Blue, $"Group adini daxil edin: ");
            string groupName = Console.ReadLine().Trim();
            Helper.PrintConsole(ConsoleColor.Blue, $"Teacher Name daxil edin: ");
            string teacherName = Console.ReadLine().Trim();
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        SelectCase: Helper.PrintConsole(ConsoleColor.Blue, $"Add Group RoomCount: ");
            string groupRoomCount = Console.ReadLine();
            int roomCount;

<<<<<<< HEAD


            bool isRoomCount = int.TryParse(groupRoomCount, out roomCount);
            if (isRoomCount)
            {
                Group group = new Group { Name = groupName, Teacher = teacherName, Room = roomCount };
                group = _groupService.CreateGroup(group);
=======
            bool isRoomCount=int.TryParse( groupRoomCount, out roomCount);
            if (isRoomCount) 
            {
                Group group = new Group { Name = groupName, Teacher = teacherName, Room = roomCount };
                group=_groupService.CreateGroup(group);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");
            }
            else
            {
<<<<<<< HEAD
                Helper.PrintConsole(ConsoleColor.Red, "Enter valid RoomCount");
=======
                Helper.PrintConsole(ConsoleColor.Red,"Enter valid RoomCount");
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                goto SelectCase;
            }

        }
<<<<<<< HEAD
        public void GetGroupById()
=======
        public void GetGroupById() 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        {
        GroupById: Helper.PrintConsole(ConsoleColor.Green, "Add Group Id: ");
            string groupId = Console.ReadLine();
            int id;
<<<<<<< HEAD
            bool isGroup = int.TryParse(groupId, out id);
            if (isGroup)
            {
                Group group = _groupService.GetGroupById(id);
=======
            bool isGroup=int.TryParse( groupId, out id);
            if (isGroup)
            {
                Group group=_groupService.GetGroupById(id);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                if (group != null)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id: {group.Id},Name: {group.Name},Teacher: {group.Teacher},Room: {group.Room}");
                }
<<<<<<< HEAD
                else
=======
                else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group Not Found");
                    goto GroupById;
                }
            }
<<<<<<< HEAD
            else
=======
            else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                Helper.PrintConsole(ConsoleColor.Red, "Group not found\nPlease enter valid id");
                goto GroupById;
            }
        }

<<<<<<< HEAD
        public void GetAllGroups()
=======
        public void GetAllGroups() 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        {
            List<Group> groups = _groupService.GetAllGroups();
            if (groups.Count != 0)
            {
                foreach (Group group in groups)
                {
                    Helper.PrintConsole(ConsoleColor.Green, $"Group Id: {group.Id},Name: {group.Name},Teacher: {group.Teacher},Room: {group.Room}");
                }
            }
<<<<<<< HEAD
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "There no group available");
            }
        }
        public void UpdateGroup()
        {

        groupId: Helper.PrintConsole(ConsoleColor.Green, "Add Group Id");
            string groupId = Console.ReadLine();
            int id;
            bool isGroupId = int.TryParse(groupId, out id);
=======
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
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
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
<<<<<<< HEAD
                else
=======
                else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                {
                    Helper.PrintConsole(ConsoleColor.Red, "Group Not Found");
                }

            }
<<<<<<< HEAD
            else
=======
            else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add Correct Group Id");
            }
        }
<<<<<<< HEAD
        public void GetGroupByTeacher()
        {
        groupTeacher: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Teacher Name");
            string teacherName = Console.ReadLine().Trim();
            Group group = _groupService.GetAllGroupByTeacher(teacherName);
=======
        public void GetGroupByTeacher() 
        {
        groupTeacher: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Teacher Name");
            string teacherName = Console.ReadLine().Trim();
            Group group=_groupService.GetAllGroupByTeacher(teacherName);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            if (group != null)
            {
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");

            }
<<<<<<< HEAD
            else
=======
            else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                Helper.PrintConsole(ConsoleColor.Red, $"There is no teacher named: {teacherName}\nEnter correct Teacher Name");
                goto groupTeacher;
            }


        }
<<<<<<< HEAD
        public void GetAllGroupByRoom()
=======
        public void GetAllGroupByRoom() 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        {
        groupRoom: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Room");
            string groupRoom = Console.ReadLine().Trim();
            int room;
<<<<<<< HEAD
            bool isGroupRoom = int.TryParse(groupRoom, out room);
            Group group = _groupService.GetAllGroupByRoomCount(room);
=======
            bool isGroupRoom=int.TryParse(groupRoom, out room);
            Group group=_groupService.GetAllGroupByRoomCount(room);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            if (group != null)
            {
                Helper.PrintConsole(ConsoleColor.Green, $"Group Id:{group.Id},Name: {group.Name}, Teacher: {group.Teacher}, Room:{group.Room}");

            }
<<<<<<< HEAD
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, $"There is no such room as: {room}");
            }
        }
        public void DeleteGroup()
=======
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red,$"There is no such room as: {room}");
            }
        }
        public void DeleteGroup() 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        {
        groupId: Helper.PrintConsole(ConsoleColor.Green, "Enter Group Id: ");
            string groupId = Console.ReadLine();
            int id;
<<<<<<< HEAD
            bool isGroupId = int.TryParse(groupId, out id);
=======
            bool isGroupId=int.TryParse(groupId, out id);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

            if (isGroupId)
            {
                _groupService.DeleteGroup(id);
<<<<<<< HEAD
                Helper.PrintConsole(ConsoleColor.Green, "Group Succesfully Deleted");
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Group Not Found\nEnter Valid Id");
=======
                Helper.PrintConsole(ConsoleColor.Green,"Group Succesfully Deleted");
            }
            else 
            {
                Helper.PrintConsole(ConsoleColor.Red,"Group Not Found\nEnter Valid Id");
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
                goto groupId;
            }

        }
<<<<<<< HEAD
        public void SearchGroupsByName()
        {
        SelectCase:
            Helper.PrintConsole(ConsoleColor.Blue, "Enter Group Name: ");
            string groupName = Console.ReadLine().Trim();
            var groups = _groupService.SearchGroupsByName(groupName);
            if (groups != null && groups.Count > 0)
            {
                foreach (var group in groups)
                {
                    Helper.PrintConsole(ConsoleColor.Green,
                        $"Group Id: {group.Id}, Name: {group.Name}, Teacher: {group.Teacher}, Room: {group.Room}\n");
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "No groups found with that name\n");
                goto SelectCase;
            }
        }
    }
}

=======
    }
}
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

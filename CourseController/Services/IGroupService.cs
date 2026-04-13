using CourseDomain.Entities;

namespace CourseService.Services
{
    public interface IGroupService
    {
        Group CreateGroup(Group group);
        Group UpdateGroup(int id, Group group);

        void DeleteGroup(int id);
        Group GetGroupById(int id);
        List<Group> GetAllGroups();
        Group GetAllGroupByTeacher(string teacher);
        Group GetAllGroupByRoomCount(int roomCount);
        List<Group> SearchGroupsByName(string name); 
    }
}


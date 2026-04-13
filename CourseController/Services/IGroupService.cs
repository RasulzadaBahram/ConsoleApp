using CourseDomain.Entities;

namespace CourseService.Services
{
    public interface IGroupService
    {
        Group CreateGroup(Group group);
<<<<<<< HEAD
        Group UpdateGroup(int id, Group group);
=======
        Group UpdateGroup(int id,Group group);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        void DeleteGroup(int id);
        Group GetGroupById(int id);
        List<Group> GetAllGroups();
        Group GetAllGroupByTeacher(string teacher);
        Group GetAllGroupByRoomCount(int roomCount);
<<<<<<< HEAD
        List<Group> SearchGroupsByName(string name); 
    }
}
=======
    }
}
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

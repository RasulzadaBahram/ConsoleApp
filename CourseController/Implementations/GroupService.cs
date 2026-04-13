using CourseDomain.Entities;
using CourseRepository.Repositories.Implementation;
using CourseService.Services;

namespace CourseService.Implementations
{
    public class GroupService : IGroupService
    {
        private GroupRepositor _groupRepositor;
        private static int _count = 1;

        public GroupService()
        {
            _groupRepositor=new GroupRepositor();
        }

        public Group CreateGroup(Group group)
        {
            group.Id = _count;
            _groupRepositor.Create(group);
            _count++;
            return group;

        }

        public void DeleteGroup(int id)
        {
            Group group = _groupRepositor.Get(x => x.Id == id);
            _groupRepositor.Delete(group);
        }

        public List<Group> GetAllGroups()
        {
            return _groupRepositor.GetAll(null);
        }

        public Group GetGroupById(int id)
        {
            Group group = _groupRepositor.Get(x => x.Id == id);
            return group;
        }

        public Group GetAllGroupByRoomCount(int roomCount)
        {
            Group group = _groupRepositor.Get(x => x.Room == roomCount);
            return group;
        }   

        public Group GetAllGroupByTeacher(string teacher)
        {
            Group group = _groupRepositor.Get(x => x.Teacher == teacher);
            return group;
        }

        public Group UpdateGroup(int id, Group group)
        {
            _groupRepositor.Update(group);
            return group;
        }
    }
}

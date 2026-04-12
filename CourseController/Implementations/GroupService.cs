using CourseDomain.Entities;
using CourseRepository.Repositories.Implementation;
using CourseService.Services;

namespace CourseService.Implementations
{
    public class GroupService : IGroupService
    {
        private GroupRepositor _groupRepositor;
        private int _count = 1;
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
            Group group = _groupRepositor.Get(l=>l.Id==id);
        }

        public List<Group> GetAllGroups()
        {
            return _groupRepositor.GetAll();
        }

        public Group GetGroupById(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroupByRoomCount(int roomCount)
        {
            throw new NotImplementedException();
        }

        public Group GetGroupByTeacher(string teacher)
        {
            throw new NotImplementedException();
        }

        public Group UpdateGroup(int id, Group group)
        {
            throw new NotImplementedException();
        }
    }
}

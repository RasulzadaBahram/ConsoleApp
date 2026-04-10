using CourseDomain.Entities;

namespace CourseService.Services
{
    public interface IGroupService
    {
        Group Create(Group group);
        Group Update(int id,Group group);
        void Delete(int id);
        Group GetGroupById(int id);
    }
}

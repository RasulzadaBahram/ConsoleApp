using CourseDomain.Entities;
using CourseRepository.Repositories.Implementation;
using CourseService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseService.Implementations
{
    public class GroupService : IGroupService
    {
        private GroupRepositor _groupRepositor;
        int _count = 1;

        public Group Create(Group group)
        {
            group.Id = _count;
            _groupRepositor.Create(group);
            _count++;
            return group;
             
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroupById(int id)
        {
            throw new NotImplementedException();
        }

        public Group Update(int id, Group group)
        {
            throw new NotImplementedException();
        }
    }
}

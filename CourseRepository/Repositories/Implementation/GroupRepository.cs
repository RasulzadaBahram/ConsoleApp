using CourseDomain.Entities;
using CourseRepository.Data;
using CourseRepository.Repositories.Exceptions;
using CourseRepository.Repositories.Interface;


namespace CourseRepository.Repositories.Implementation
{
    public class GroupRepositor : IRepository<Group>
    {
        public void Create(Group data)
        {
            try
            {
                if (data == null) throw new NotFoundException("Data not found");
                AppDbContext<Group>.datas.Add(data);
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
        public void Update(Group data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Group data)
        {
            throw new NotImplementedException();
        }

        public Group GeById(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }


    }
}

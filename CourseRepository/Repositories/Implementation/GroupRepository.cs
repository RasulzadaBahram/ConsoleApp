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
            try
            {
                if (data == null)
                {
                    throw new NotFoundException("Data not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(Group data)
        {
            try
            {
                if (data == null)
                {
                    throw new NotFoundException("Data not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            AppDbContext<Group>.datas.Remove(data);
        }

        public Group Get(Predicate<Group> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Group>.datas.Find(predicate);
            }
            else
            {
                return null;
            }
        }

        public List<Group> GetAll(Predicate<Group> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Group>.datas.FindAll(predicate);
            }
            else
            {
                return AppDbContext<Group>.datas;
            }
        }
        public List<Group> GetAllGroupsByTeacher(string teacher)
        {
            return AppDbContext<Group>.datas.FindAll(x => x.Teacher == teacher);

        }
        public List<Group> GetAllGroupsByName(int room)
        {
            return AppDbContext<Group>.datas.FindAll(x => x.Room == room);
        }


    }
<<<<<<< HEAD
}
=======
}
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

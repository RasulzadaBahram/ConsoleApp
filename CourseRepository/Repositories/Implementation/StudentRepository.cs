using CourseDomain.Entities;
using CourseRepository.Data;
using CourseRepository.Repositories.Exceptions;
using CourseRepository.Repositories.Interface;

namespace CourseRepository.Repositories.Implementation
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student data)
        {
            try
            {
                if (data == null)
<<<<<<< HEAD
                    throw new NotFoundException("Data Not Found");

                AppDbContext<Student>.datas.Add(data);
            }
            catch (Exception ex)
=======
                {
                    throw new NotFoundException("Data Not Found");
                }
            }
            catch (Exception ex) 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(Student data)
        {
            try
            {
                if (data == null)
<<<<<<< HEAD
                    throw new NotFoundException("Data Not Found");

                AppDbContext<Student>.datas.Remove(data);
=======
                {
                    throw new NotFoundException("Data Not Found");
                }
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
<<<<<<< HEAD
=======
           AppDbContext<Student>.datas.Remove(data);
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
        }

        public Student Get(Predicate<Student> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Student>.datas.Find(predicate);
            }
<<<<<<< HEAD
            else
=======
            else 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                return null;
            }
        }

        public List<Student> GetAll(Predicate<Student> predicate)
        {
            if (predicate != null)
            {
                return AppDbContext<Student>.datas.FindAll(predicate);
            }
            else
            {
<<<<<<< HEAD
                return AppDbContext<Student>.datas;
=======
                return null;
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            }
        }

        public void Update(Student data)
        {
            try
            {
<<<<<<< HEAD
                if (data == null)
                    throw new NotFoundException("Data Not Found");
            }
            catch (Exception ex)
=======
                if (data == null) 
                {
                    throw new NotFoundException("Data Not Found");
                }
            }
            catch (Exception ex) 
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56
            {
                Console.WriteLine(ex.Message);
            }
        }
<<<<<<< HEAD
    }
}
=======
        public void GetAllStudentsByGroupId(int id) 
        {
            List<Student> students = AppDbContext<Student>.datas.FindAll(x => x.Group.Id == id);
            if (students == null) 
            {
                throw new NotFoundException("Data Not Found");
            }
        }
    }
}
>>>>>>> d75579d7ee9c5a91de1f72e307ef880627a56f56

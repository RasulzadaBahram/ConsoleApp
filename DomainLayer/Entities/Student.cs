using CourseDomain.Common;

namespace CourseDomain.Entities
{
    public class Student:BaseEntities
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
    
    }
}

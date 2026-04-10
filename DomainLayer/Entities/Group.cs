using CourseDomain.Common;


namespace CourseDomain.Entities
{
    public class Group:BaseEntities
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }
    }
}

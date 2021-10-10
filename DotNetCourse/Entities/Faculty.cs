using System.Collections.Generic;

namespace DotNetCourse.Entities
{
    class Faculty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public static List<Faculty> GetList()
        {
            List<Faculty> List = new List<Faculty>();
            List.Add(new Faculty
            {
                Id = "1",
                Name = "Khoa CNTT"
            });
            List.Add(new Faculty
            {
                Id = "2",
                Name = "Khoa Hoa"
            });
            List.Add(new Faculty
            {
                Id = "1",
                Name = "Khoa Van"
            });
            return List;
        }
    }
}

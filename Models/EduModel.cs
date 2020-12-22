using System;
using System.Collections.Generic;
using System.Text;

namespace cusrse_work_forth.Models
{
    public class EduModel
    {
        public EduModel(string name, string type, string direction)
        {
            Name = name;
            Type = type;
            Direction = direction;
        }

        public EduModel(int id, string name, string type, string direction)
        {
            Id = id;
            Name = name;
            Type = type;
            Direction = direction;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
    }
}

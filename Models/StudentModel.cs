using System;
using System.Collections.Generic;
using System.Text;

namespace cusrse_work_forth.Models
{
    public class StudentModel
    {
        public StudentModel(int id, string name, string birthday, string school)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            School = school;
        }


        public StudentModel(string name, string birthday, string school)
        {
            Name = name;
            Birthday = birthday;
            School = school;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string School { get; set; }
    }
}

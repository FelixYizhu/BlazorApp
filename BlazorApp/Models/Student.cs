using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
    //Enum for Gender, female is 0 and male is 1
    public enum Gender
    {
        female = 0,
        male = 1
    }
}
}

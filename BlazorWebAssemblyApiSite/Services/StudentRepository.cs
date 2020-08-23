using BlazorWebAssemblyApiSite.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApiSite.Services
{
    public class StudentRepository : IStudentRepository
    {

        //create student list
        private static List<Student> Students = new List<Student>()
        {
            new Student{Id=1, Name="Felix", Age=10, Class="Class 1", Gender=Gender.male},
            new Student{Id=1, Name="Tom", Age=9, Class="Class 1", Gender=Gender.male},
            new Student{Id=1, Name="Tim", Age=9, Class="Class 2", Gender=Gender.male},
            new Student{Id=1, Name="Sherry", Age=10, Class="Class 3", Gender=Gender.female},
            new Student{Id=1, Name="Mary", Age=10, Class="Class 3",Gender=Gender.female},
            new Student{Id=1, Name="Redas", Age=10, Class="Class 3",Gender=Gender.female}
        };

        public bool Add(Student student)
        {
            Students.Add(student);
            return true;
        }

        public bool Delete(int id)
        {
            var student= Students.SingleOrDefault(x => x.Id == id);
            if(student!=null)
            {
                Students.Remove(student);
            }
            return true;
        }

        public List<Student> GetAll()
        {
            return Students;
        }

        public Student GetStudentById(int id)
        {
            Student student = Students.SingleOrDefault(x => x.Id == id);
            return student;
        }

        public bool Update(Student student)
        {
            var stu = Students.SingleOrDefault(x => x.Id == student.Id);
            if(stu!=null)
            {
                Students.Remove(stu);
            }
            Students.Add(student);
            return true;
        }
    }
}

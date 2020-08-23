using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Store
    {
        private List<Student> _students;

        public void SetStudents(List<Student> list)
        {
            _students = list;
        }
        public List<Student> GetStudents()
        {
            return _students;
        }

        public Student GetStudentById(int id)
        {
            var stu = _students.SingleOrDefault(x => x.Id == id);
            return stu;
        }
    }
}

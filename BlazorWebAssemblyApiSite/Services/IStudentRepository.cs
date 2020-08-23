using BlazorWebAssemblyApiSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApiSite.Services
{
    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student GetStudentById(int id);

        bool Add(Student student);

        bool Update(Student student);

        bool Delete(int id);
    }
}

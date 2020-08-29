using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorWebAssemblyApiSite.Services;
using BlazorWebAssemblyApiSite.Model;
namespace BlazorWebAssemblyApiSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        [HttpPost]
        public Student Add(Student student)
        {
            _studentRepository.Add(student);
            return student;
        }

        [HttpPut]
        public Student Modify(Student student)
        {
            _studentRepository.Update(student);
            return student;
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

    }
}

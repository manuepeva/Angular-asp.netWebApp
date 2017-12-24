using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiV2.Models;

namespace WebApiV2.Controllers
{
    public class StudentV2Controller : ApiController
    {
        static List<StudentV2> students = new List<StudentV2>()
       {
           new StudentV2() {Id = 1, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot"},
           new StudentV2() {Id = 2, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot" },
           new StudentV2() {Id = 3, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot"},
       };

        public IEnumerable<StudentV2> Get()

        {
            return students;
        }

        public StudentV2 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}

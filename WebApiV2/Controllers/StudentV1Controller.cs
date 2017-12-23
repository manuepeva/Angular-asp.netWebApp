using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiV2.Models;

namespace WebApiV2.Controllers
{
    public class StudentV1Controller : ApiController
    {
        static List<StudentV1> students = new List<StudentV1>()
       {
           new StudentV1() {Id = 1, FirstName = "Lucho", LastName = "Quedaza"},
           new StudentV1() {Id = 2, FirstName = "Lucho", LastName = "Quedaza"},
           new StudentV1() {Id = 3, FirstName = "Lucho", LastName = "Quedaza"},
       };

        public IEnumerable<StudentV1> Get()
        {
            return students;
        }


        public StudentV1 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}

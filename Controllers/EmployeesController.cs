using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sql_Connections.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<EMPLOYEESTABLE> Get()
        {
            using(myDBConnection entities = new myDBConnection())
            {
                return entities.EMPLOYEESTABLE.ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_Demo
{
    interface IDepartment
    {
        public IEnumerable<Department> GetAllDepartments();
    }
}

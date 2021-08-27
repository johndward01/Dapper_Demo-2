using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dapper_Demo
{
    class DepartmentRepo : IDepartment
    {
        private readonly IDbConnection _conn;

        public DepartmentRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM Departments;");
        }
    }
}

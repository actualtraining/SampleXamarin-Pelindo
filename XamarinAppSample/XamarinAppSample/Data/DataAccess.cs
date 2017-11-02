
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite.Net;
using Xamarin.Forms;
using XamarinAppSample.Models;

namespace XamarinAppSample.Data
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLIte>().GetConnection();
            dbConn.CreateTable<Employee>();
        }

        public List<Employee> GetAll()
        {
            return dbConn.Query<Employee>("select * from Employee order by EmpName");
        }

        public int Insert(Employee employee)
        {
            return dbConn.Insert(employee);
        }

        public int Update(Employee employee)
        {
            return dbConn.Update(employee);
        }

        public int Delete(Employee employee)
        {
            return dbConn.Delete(employee);
        }
    }
}

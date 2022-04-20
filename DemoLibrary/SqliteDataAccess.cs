using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testconnectionstring";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading  SQLite Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }

    public class SqliteDataAccess2 : DataAccess
    {
        // LoadConnectionString is coming from the base class

        // Implement the abstract member
        public override void LoadData(string sql)
        {
            throw new NotImplementedException();
        }

        // if we want we can override
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}

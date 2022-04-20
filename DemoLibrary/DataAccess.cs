using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // "is-a relationship"
    public abstract class DataAccess
    {
        // cannot override
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testconnectionstring";
        }

        public abstract void LoadData(string sql);

        // the below method can be overridden in the child class
        public virtual void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}

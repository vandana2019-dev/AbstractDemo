// See https://aka.ms/new-console-template for more information
using DemoLibrary;

List<IDataAccess> databases = new List<IDataAccess>()
{
    new SqlDataAccess(),
    new SqliteDataAccess()
};

foreach(var db in databases)
{
    db.LoadConnectionString("demo");
    db.LoadData("select * from table");
    db.SaveData("insert into table");

    Console.WriteLine();
}


// Using Abstract class - we blend the two together (base class and the interface)  we cannot create an instance of abstract class
Console.WriteLine(" ** Abstract class ** ");
DataAccess db2 = new SqliteDataAccess2();
db2.LoadConnectionString("sqllite");

db2 = new SqlDataAccess2();
db2.LoadConnectionString("sql");

Console.ReadLine();
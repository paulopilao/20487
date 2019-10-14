using System;
using modulo2.DAL.Contexts;
using modulo2.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Modulo2.ConsoleApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var optionsBuilder = new DbContextOptionsBuilder<Modulo2Context>();
            optionsBuilder.UseSqlServer("Data Source=tcp:20487.database.windows.net,1433;Initial Catalog=modulo1pipsdb;User Id=pilao@20487.database.windows.net;Password=!QAZ.2wsx.;");
            var repo = new ClienteRepository(new Modulo2Context(optionsBuilder.Options));
            foreach (var item in repo.GetAll())
            {
                        Console.WriteLine(item.Nome);
            }
        }
    }
}

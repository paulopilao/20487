using System;
using Demonstracao1.DataBase;

namespace Demonstracao1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                DbInitializer.Initialize(context);
            }
            Console.WriteLine("Database created");
        }
    }
}

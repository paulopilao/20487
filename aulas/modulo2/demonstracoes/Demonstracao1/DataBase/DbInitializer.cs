using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstracao1.DataBase
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated();
            // Code to create initial data
        }
    }
}

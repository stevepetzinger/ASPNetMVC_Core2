using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComputerStore.DAL.SqlServer
{
    /// <summary>
    /// TODO: finish seeding the database
    /// </summary>
    public class DbInitializer
    {
        public static void Initialize(ComputerStoreContext context)
        {
            context.Database.EnsureCreated();

            // Look for any computers
            if (context.Computers.Any())
            {
                return;   // DB has been seeded
            }

            var computers = new Entities.Computer[]
            {
                new Entities.Computer {Brand = "HP", RAM = 16 }
            };
            foreach (var c in computers)
            {
                context.Computers.Add(c);
            }
            context.SaveChanges();
        }
    }
}

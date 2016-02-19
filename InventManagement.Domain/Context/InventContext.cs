using InventManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventManagement.Domain.Context
{
    public class InventContext : DbContext
    {
        public InventContext() : base("name=DefaultConnection")
        {
            //get the database connection
        }

        public DbSet<InventoryPart> Parts { get; set; }
        
    }
}

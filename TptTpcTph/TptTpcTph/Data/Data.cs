using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TptTpcTph.Models;

namespace TptTpcTph.Data
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> opt) : base(opt)
        {
            
        }
        public DbSet<Player> players { get; set; }
        public DbSet<Person> MyProperty { get; set; }
        public DbSet<Metric> Metrics { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAINING.DATABASE.Models;

namespace TRAINING.DATABASE.Data
{
    public class TrainningContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Trainging;Integrated Security=True;");


            }
        }
            public DbSet<Student> Student { get; set; }
            public DbSet<UnderGraduateStudent> UnderGraduateStudent { get; set; }
    }

}



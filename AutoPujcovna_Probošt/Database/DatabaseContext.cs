using AutoPujcovna_Probošt.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Database
{
        public class DatabaseContext : DbContext
        {
            public DbSet<Car> Cars { get; set; }
            public DbSet<Rental> Rentals { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseMySQL(
                    //"server=localhost;database=car_rental;user=root;charset=utf8;"
                    "server=mysqlstudenti.litv.sssvt.cz;database=3c2_probostvojtech_db2;user=probostvojtech;password=123456;charset=utf8;"

                );
            }
        }
}

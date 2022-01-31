using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Core.Models;
using System.Data.SqlClient; 

namespace TestTask.DAL
{
    public class TaxContext : DbContext
    {
        public DbSet<Fee> Fees { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Tax> Taxes { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public TaxContext(DbContextOptions<TaxContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<State>().HasData(new State() { Id = 1, Code = "CA" }, new State() { Id = 2, Code = "NY" }, new State() { Id = 3, Code = "FL" });

            modelBuilder.Entity<Fee>().HasData(new Fee() { Id = 1, StateId = 1, Zipcode = "90011", FeeValue = 100 },
                                                new Fee() { Id = 2, StateId = 1, Zipcode = "90044", FeeValue = 120 },
                                                new Fee() { Id = 3, StateId = 1, Zipcode = "90201", FeeValue = 130 },
                                                new Fee() { Id = 4, StateId = 1, Zipcode = "90650", FeeValue = 110 },
                                                new Fee() { Id = 5, StateId = 1, Zipcode = "91331", FeeValue = 90 },
                                                new Fee() { Id = 6, StateId = 2, Zipcode = "10001", FeeValue = 80 },
                                                new Fee() { Id = 7, StateId = 2, Zipcode = "10002", FeeValue = 140 },
                                                new Fee() { Id = 8, StateId = 2, Zipcode = "10003", FeeValue = 70 },
                                                new Fee() { Id = 9, StateId = 2, Zipcode = "10004", FeeValue = 84 },
                                                new Fee() { Id = 10, StateId = 2, Zipcode = "10005", FeeValue = 96 },
                                                new Fee() { Id = 11, StateId = 3, Zipcode = "32004", FeeValue = 36 },
                                                new Fee() { Id = 12, StateId = 3, Zipcode = "32006", FeeValue = 58 },
                                                new Fee() { Id = 13, StateId = 3, Zipcode = "32007", FeeValue = 64 },
                                                new Fee() { Id = 14, StateId = 3, Zipcode = "32008", FeeValue = 98 },
                                                new Fee() { Id = 15, StateId = 3, Zipcode = "32009", FeeValue = 115 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = 1, Name = "Passenger" }, new Vehicle() { Id = 2, Name = "Truck" }, new Vehicle() { Id = 3, Name = "Trailer" });

            modelBuilder.Entity<Tax>().HasData(new Tax() { Id = 1, StateId = 1, VehicleId = 1, Coefficient = 1.05 },
                                                new Tax() { Id = 2, StateId = 1, VehicleId = 2, Coefficient = 1.2 },
                                                new Tax() { Id = 3, StateId = 1, VehicleId = 3, Coefficient = 1.25 },
                                                new Tax() { Id = 4, StateId = 2, VehicleId = 1, Coefficient = 0.9 },
                                                new Tax() { Id = 5, StateId = 2, VehicleId = 2, Coefficient = 1.5 },
                                                new Tax() { Id = 6, StateId = 2, VehicleId = 3, Coefficient = 1.5 },
                                                new Tax() { Id = 7, StateId = 3, VehicleId = 1, Coefficient = 1.1 },
                                                new Tax() { Id = 8, StateId = 3, VehicleId = 2, Coefficient = 1.5 },
                                                new Tax() { Id = 9, StateId = 3, VehicleId = 3, Coefficient = null });
        }
    }
}

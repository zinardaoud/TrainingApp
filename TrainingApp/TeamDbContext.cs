using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp
{
    internal class TeamDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Training> Trainings { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Using an Instance of singleton object 
            var con = SingeltonConnection.Instance;
            
            optionsBuilder.UseSqlServer(con.Con());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(new Player { Id = 1, FirstName = "Thibaut", LastName = "Courtois", Age = 30, Position = "GK"});
            modelBuilder.Entity<Player>().HasData(new Player { Id = 2, FirstName = "Daniel", LastName = "Carvajal", Age = 30, Position = "RB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 3, FirstName = "Eder", LastName = "Militao", Age = 24, Position = "CB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 4, FirstName = "David", LastName = "Alaba", Age = 30, Position = "CB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 5, FirstName = "Jesus", LastName = "Vallejo", Age = 25, Position = "CB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 6, FirstName = "Nacho", LastName = "Fernandez", Age = 32, Position = "CB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 7, FirstName = "Eden", LastName = "Hazard", Age = 31, Position = "LW" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 8, FirstName = "Toni", LastName = "Kroos", Age = 32, Position = "CM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 9, FirstName = "Karim", LastName = "Benzema", Age = 34, Position = "CF" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 10, FirstName = "Luka", LastName = "Modric", Age = 36, Position = "CM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 11, FirstName = "Marco", LastName = "Asensio", Age = 26, Position = "RW" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 13, FirstName = "Andriy", LastName = "Lunin", Age = 23, Position = "GK" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 14, FirstName = "Carlos", LastName = "Casemiro", Age = 30, Position = "CDM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 15, FirstName = "Federico", LastName = "Valverde", Age = 23, Position = "CM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 16, FirstName = "Luka", LastName = "Jovic", Age = 24, Position = "CF" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 17, FirstName = "Lucas", LastName = "Vazquez", Age = 31, Position = "RB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 18, FirstName = "Aurelien", LastName = "Tchoumeni", Age = 22, Position = "CDM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 19, FirstName = "Dani", LastName = "Ceballos", Age = 25, Position = "CM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 20, FirstName = "Vinicius", LastName = "Junior", Age = 21, Position = "LW" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 21, FirstName = "Rodrygo", LastName = "Goes", Age = 21, Position = "RW" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 22, FirstName = "Antonio", LastName = "Rudiger", Age = 29, Position = "CB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 23, FirstName = "Ferland", LastName = "Mendy", Age = 27, Position = "LB" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 24, FirstName = "Mariano", LastName = "Diaz", Age = 28, Position = "CF" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 25, FirstName = "Eduardo", LastName = "Camavinga", Age = 19, Position = "CM" });
            modelBuilder.Entity<Player>().HasData(new Player { Id = 35, FirstName = "Miguel", LastName = "Gutierrez", Age = 20, Position = "LB" });


            modelBuilder.Entity<Match>().HasData(new Match { MatchId = 1, Field = "A", SessionDate = DateTime.Now.AddDays(30), SessionStart = "20:00", SessionEnd = "21:30" });
            modelBuilder.Entity<Match>().HasData(new Match { MatchId = 2, Field = "A", SessionDate = DateTime.Now.AddDays(35), SessionStart = "20:00", SessionEnd = "21:30" });
            modelBuilder.Entity<Match>().HasData(new Match { MatchId = 3, Field = "A", SessionDate = DateTime.Now.AddDays(40), SessionStart = "20:00", SessionEnd = "21:30" });

            modelBuilder.Entity<Training>().HasData(new Training { TrainingId = 1, Field = "B", SessionDate = DateTime.Now.AddDays(2), SessionStart = "20:00", SessionEnd = "21:30" });
            modelBuilder.Entity<Training>().HasData(new Training { TrainingId = 2, Field = "B", SessionDate = DateTime.Now.AddDays(4), SessionStart = "20:00", SessionEnd = "21:30" });
            modelBuilder.Entity<Training>().HasData(new Training { TrainingId = 3, Field = "B", SessionDate = DateTime.Now.AddDays(6), SessionStart = "20:00", SessionEnd = "21:30" });


        }


    }
}

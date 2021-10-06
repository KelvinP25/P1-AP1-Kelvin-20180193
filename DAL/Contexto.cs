using Microsoft.EntityFrameworkCore;
using P1_AP1_Kelvin_20180193.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1_AP1_Kelvin_20180193.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> aportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Aportes.db");
        }
    }
}

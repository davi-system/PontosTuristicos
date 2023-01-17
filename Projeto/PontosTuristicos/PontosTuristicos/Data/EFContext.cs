using Microsoft.EntityFrameworkCore;
using PontosTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicos.Data
{
    public class EFContext : DbContext
    {
        //private const string connectionString = "Server=DAVI\\SQLEXPRESS;Database=pontos_turisticos;Trusted_Connection=True;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseSqlServer(connectionString);
        //}

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<PontoTuristico> PontoTuristico { get; set; }        
    }
}

using Microsoft.EntityFrameworkCore;
using PontosTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicos.Data
{
    public class PontosTuristicosContext : DbContext
    {      
        public PontosTuristicosContext(DbContextOptions<PontosTuristicosContext> options) : base(options)
        {
        }

        public DbSet<PontoTuristico> PontoTuristico { get; set; }        
    }
}

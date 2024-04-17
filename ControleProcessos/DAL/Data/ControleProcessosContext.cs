using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ControleProcessos.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleProcessos.DAL.Data
{
    public class ControleProcessosContext : DbContext
    {
        ////public ControleProcessosContext(DbContextOptions<ControleProcessosContext> options)
        ////    : base(options)
        ////{
        ////}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=ControleProcessos;Integrated Security=True;Encrypt=False");
            }
        }

        public DbSet<Area> Areas { get; set; } = default!;
        public DbSet<Processo> Processos { get; set; } = default!;
        public DbSet<ProcessoTipo> ProcessoTipos { get; set;} = default!;
       


    }
}

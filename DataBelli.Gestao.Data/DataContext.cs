using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataBelli.SistemaGestao.Negocio;

namespace DataBelli.Gestao.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Beneficiario> Beneficiarios { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Beneficiario>.
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

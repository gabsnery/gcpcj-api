using Microsoft.EntityFrameworkCore;
using PROJGCPSJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJGCPSJ
{
    public class APIMeuContexto : DbContext
    {
       // public DbSet<Empresa> Empresas { get; set; }
        //public DbSet<telefone> Telefones { get; set; }
        public DbSet<tbcontrato> tbcontrato { get; set; }
        public DbSet<tbacaopap> tbacaopap { get; set; }
        public DbSet<tbarea> TbArea { get; set; }
        public DbSet<tbarqv> TbArquivos { get; set; }
        public DbSet<tbatributo> TbAtributo { get; set; }
        public DbSet<auditoria> TbAuditoria { get; set; }
        public DbSet<tbcontato> TbContato { get; set; }
        public DbSet<tbempresa> TbEmpresa { get; set; }
    


        //para criar o construtos: ctor + tab
        public APIMeuContexto(DbContextOptions<APIMeuContexto>options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            //modelBuilder.UsePropertyAccessMode
        }
    }
}

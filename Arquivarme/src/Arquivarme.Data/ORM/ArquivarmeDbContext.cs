using Arquivarme.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arquivarme.Data.ORM
{
    public class ArquivarmeDbContext : DbContext
    {
        public ArquivarmeDbContext(DbContextOptions<ArquivarmeDbContext> options) : base(options) 
        { }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Categoria> Categoria { get; set; }
        
        public DbSet<Geolocalizacao> Geolocalizacao { get; set; }
       
        public DbSet<CaixaArquivo> CaixaArquivo { get; set; }
        
        public DbSet<CapaArquivo> CapaArquivo { get; set; }
        
        public DbSet<TipoMovimento> TipoMovimento { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}

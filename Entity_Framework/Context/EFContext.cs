using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_Framework.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EF")
        {
            DropCreateDatabaseIfModelChanges<EFContext> initializer = new DropCreateDatabaseIfModelChanges<EFContext>();
            Database.SetInitializer<EFContext>(initializer);
        }

        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}
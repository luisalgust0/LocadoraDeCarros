using Dados.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Contexts
{
    public class LocadoraDbContext : DbContext
    {
            public LocadoraDbContext(DbContextOptions options) : base(options)
            {
                this.Database.SetConnectionString("Server=localhost;Initial Catalog=locadoraDB;User Id=sa;Password=Gorilla22!;");
            }

             public DbSet<ClienteModel> Cliente { get; set; }
      
    }

}


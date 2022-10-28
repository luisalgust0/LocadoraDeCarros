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

            }

            // public DbSet<ClienteModel> Cliente { get; set; }
      
    }

}


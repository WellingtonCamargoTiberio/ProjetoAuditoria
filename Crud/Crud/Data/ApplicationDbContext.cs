using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Crud.Models;

namespace Crud.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<LogAuditoria> LogAuditoria { get; set; }
        public DbSet<Crud.Models.Cliente> Cliente { get; set; }

    }
}

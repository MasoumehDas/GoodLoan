using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public partial class RepositoryDbContext : DbContext
    {


        public RepositoryDbContext()
        {
        }

        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Enum> Enums { get; set; }
        public virtual DbSet<Installment> Installments { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserMenu> UserMenu { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserRoleMenuAccess> UserRoleMenuAccess { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
    }
}

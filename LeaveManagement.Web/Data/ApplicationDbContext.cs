﻿using LeaveManagement.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfig());
            builder.ApplyConfiguration(new UserSeedConfig());
            builder.ApplyConfiguration(new UserRoleSeedConfig());
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}

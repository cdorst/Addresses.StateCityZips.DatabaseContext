// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.StateCities.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.StateCityZips.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for StateCityZip entities</summary>
    public class StateCityZipDbContext : StateCityDbContext
    {
        /// <summary>Constructs StateCityZipDbContext EntityFrameworkCore database context using given options</summary>
        public StateCityZipDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of StateCityZip entities</summary>
        public DbSet<StateCityZip> StateCityZips { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StateCityZip>().HasIndex(new StateCityZip().GetUniqueIndex()).IsUnique();
        }
    }
}

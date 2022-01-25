using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dal {
   public partial class trucktrackContext: DbContext
   {
      public trucktrackContext() {}

      public trucktrackContext(DbContextOptions<trucktrackContext> options): base(options) {}

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         if (!optionsBuilder.IsConfigured)
         {}
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<User>());
      }
   }
}
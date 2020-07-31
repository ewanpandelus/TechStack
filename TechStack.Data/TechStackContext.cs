using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TechStackApp.Domain;

namespace TechStack.Data
{
   public class TechStackContext: DbContext
    {
        public DbSet<TechStackApp.Domain.TechStack> TechStacks { get; set; } //TechStack clashes with solution name
        public DbSet<Technology> Technologies { get; set; }
    }
}

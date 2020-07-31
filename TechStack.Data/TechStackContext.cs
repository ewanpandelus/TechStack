using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TechStack.Domain;

namespace TechStack.Data
{
   public class TechStackContext: DbContext
    {
        public DbSet<TechStack.Domain.TechStack> TechStacks { get; set; } 
        public DbSet<Technology> Technologies { get; set; }
    }
}

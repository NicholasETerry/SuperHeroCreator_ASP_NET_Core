using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHeros> SuperHero { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

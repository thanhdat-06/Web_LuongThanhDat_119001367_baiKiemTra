#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TinTuc.Models;

    public class TinTucContext : DbContext
    {
        public TinTucContext (DbContextOptions<TinTucContext> options)
            : base(options)
        {
        }

        public DbSet<TinTuc.Models.Category> Category { get; set; }

        public DbSet<TinTuc.Models.Comment> Comment { get; set; }

        public DbSet<TinTuc.Models.News> News { get; set; }
    }

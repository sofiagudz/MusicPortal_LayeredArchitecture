using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.Entities;

namespace MusicPortal.DAL.EF
{
    public class MusicPortalContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<User> Users { get; set; }
        public MusicPortalContext(DbContextOptions<MusicPortalContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

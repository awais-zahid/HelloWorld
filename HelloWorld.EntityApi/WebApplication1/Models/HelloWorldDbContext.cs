using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace WebApplication1.Models
{
    public class TitlePageContext : DbContext
    {
        public TitlePageContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<TitlePage> titlePage { get; set; }
    }
}

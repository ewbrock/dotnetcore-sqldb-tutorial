﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreSqlDb.Models
{
    public class WineContext : DbContext
    {
        public WineContext (DbContextOptions<WineContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreSqlDb.Models.Climate> Climate { get; set; }
    }
}

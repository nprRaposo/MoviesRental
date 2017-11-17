﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRental.Models
{
    public class MoviesRentalContext : DbContext
    {
        public MoviesRentalContext(DbContextOptions<MoviesRentalContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}

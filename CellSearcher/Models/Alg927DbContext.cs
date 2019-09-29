using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellSearcher.Models {
    public class Alg927DbContext : DbContext {

        public virtual DbSet<Alg> Algs { get; set; }
        public virtual DbSet<Cell> Cells { get; set; }
        public virtual DbSet<Line> Lines { get; set; }

        public Alg927DbContext(DbContextOptions<Alg927DbContext> context) : base(context) {

        }

    }
}

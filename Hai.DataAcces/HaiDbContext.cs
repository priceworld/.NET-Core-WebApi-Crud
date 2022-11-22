using Hai.Entities;
using Hai.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hai.DataAcces
{
    public class HaiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-UU8ITLT;Database=PROD_INAN;Integrated Security=true;");
        }
        public DbSet<GoodsIN> GoodsIN { get; set; }
        public DbSet<GoodsINDetail> GoodsINDetail { get; set; }
        public DbSet<GoodsOut> GoodsOut { get; set; }
        public DbSet<GoodsINDetailProduct> GIDProduct { get; set; }
        public DbSet<UserDto> Users { get; set; }
    }
}

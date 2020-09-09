﻿using Microsoft.EntityFrameworkCore;

namespace ProductManagementWebApi.Models
{
    public class ProductManagementContext : DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductWarehouseStock> ProductWarehouseStocks { get; set; }
    }
}

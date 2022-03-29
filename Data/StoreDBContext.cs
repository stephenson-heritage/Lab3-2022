#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;
using Microsoft.EntityFrameworkCore;

public class StoreDBContext : DbContext
{
	public StoreDBContext(DbContextOptions<StoreDBContext> options)
		 : base(options)
	{
	}

	public DbSet<Product> Product { get; set; }
	public DbSet<User> User { get; set; }
}

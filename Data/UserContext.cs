using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TapShoesCanada.Models;

namespace TapShoesCanada.Data
{
	public class UserContext: DbContext
	{
		public UserContext(DbContextOptions<UserContext> options) : base(options) 
		{}

		//public UserContext() : base("Tap_Shoes_Canada_DB") { }

		public DbSet<User> Users { get; set; }

	}
}

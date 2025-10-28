using Microsoft.EntityFrameworkCore;
using HashBlogs.Models;

namespace HashBlogs.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{ }

		// Your Models Go Here
		//public DbSet<MY_MODEL> MODEL_NAME { get; set; }

		public DbSet<Blog> Blogs { get; set; }	
	}
}

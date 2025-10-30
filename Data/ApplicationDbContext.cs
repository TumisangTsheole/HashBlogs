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

		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }

		// Seed Data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User { 
					UserId = 1,
					Username = "blazetza", 
					Email = "tsheoletumisang934@gmail.com",
					Password = "123456",
					FirstName = "Tumisang",
					LastName = "Tsheole",
					Bio = "Aspiring .NET Developer with skills in ASP.NET and Razor Pages",
					CreatedAt = DateTime.SpecifyKind(new DateTime(2025, 10, 28, 22, 32, 0), DateTimeKind.Utc)
				}
			);	

			
			modelBuilder.Entity<Post>().HasData(
				new Post {
					PostId = 1,
					UserId = 1,
					Title = "Introduction to ASP.NET MVC",
					CreatedAt = DateTime.SpecifyKind(new DateTime(2025, 10, 28, 22, 32, 0), DateTimeKind.Utc),
					UpdatedAt = DateTime.SpecifyKind(new DateTime(2025, 10, 28, 22, 32, 0), DateTimeKind.Utc)
				}
			);

			modelBuilder.Entity<Comment>().HasData(
				new Comment {
					CommentId = 1,
					PostId = 1,
					UserId = 1,
					CreatedAt = DateTime.SpecifyKind(new DateTime(2025, 10, 28, 22, 32, 0), DateTimeKind.Utc)
				}
			);


			
		}	
	}
}

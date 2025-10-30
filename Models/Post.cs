using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HashBlogs.Models
{
	public class Post
	{
		// Added the 'required' modifier tfor compile-time nullability safety
		// (just to silence the compiler/warnings),
		// Since the '[Required]' annotation is only for runtime validation (model binding)
		[Key]
		[Required]
		public required int PostId { get; set; }

		[ForeignKey("UserId")]
		[Required]
		public required int UserId { get; set; }

		[Required]
		public required string Title { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		[Required]
		public DateTime UpdatedAt { get; set; } = DateTime.Now;

		
		[ForeignKey("UserId")]
		[NotMapped] // Excludes navigation property from EF Core tracking
		public User? User { get; set; }

		[NotMapped]
		// Navigation Property (Post will have many comments)
		public ICollection<Comment>? Comments { get; set; }
	}
}

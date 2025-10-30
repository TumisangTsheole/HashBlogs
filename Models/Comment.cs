using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HashBlogs.Models
{
	public class Comment
	{
		// Added the 'required' modifier tfor compile-time nullability safety
		// (just to silence the compiler/warnings),
		// Since the '[Required]' annotation is only for runtime validation (model binding)
						
	
		[Key]
		[Required]
		public required int CommentId { get; set; }

		[ForeignKey("PostId")]
		[Required]
		public required int PostId { get; set; }

		[ForeignKey("PostId")]
		[NotMapped]
		public Post? Post { get; set; }

		[ForeignKey("UserId")]
		[Required]
		public required int UserId { get; set; }

		[ForeignKey("UserId")]
		[NotMapped]
		public User? User { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.Now;	
	}
}

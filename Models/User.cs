using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HashBlogs.Models
{
	public class User
	{
		// Added the 'required' modifier tfor compile-time nullability safety
		// (just to silence the compiler/warnings),
		// Since the '[Required]' annotation is only for runtime validation (model binding)

		[Key]
		public required  int UserId { get; set; }

		[Required]
		public required string Username { get; set; }

		[Required]
		[EmailAddress]
		public required string Email { get; set; }
		
		// 	NOTE! Change to PasswordHash 
		[Required]
		public required string Password { get; set; }

		[Required]
		[StringLength(30)]
		public required string FirstName { get; set; }

		[Required]
		[StringLength(30)]
		public required string LastName { get; set; }

		[StringLength(150)]
		public required string? Bio { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		// Navigation Properties (A User can have many Posts and Comments)
		public ICollection<Post>? Posts { get; set; }
		public ICollection<Comment>? Comments { get; set; }
	}
}

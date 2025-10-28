using System.ComponentModel.DataAnnotations;
namespace HashBlogs.Models
{
	public class Blog 
	{
		[Key]
		public int Id { get; set; }
	//	[Required]
		public string? title { get; set; }
	//	[Required]
		public string? author { get; set; }
	//	[Required]
		public string? content { get; set; }		
	} 
}

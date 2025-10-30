using HashBlogs.Models;

namespace HashBlogs.ViewModels
{
	public class FeedViewModel
	{
		public User? currentUser { get; set; }
		public List<Post>? Posts { get; set; }
	}
}

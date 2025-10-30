using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HashBlogs.Data;
using HashBlogs.ViewModels;

namespace HashBlogs.Controllers
{
    public class FeedController : Controller
    {
		private readonly ApplicationDbContext _context;

		public FeedController(ApplicationDbContext context)
		{
			_context = context;
		}
    	
        // GET: FeedController
        public ActionResult Index()
        {
			var user = _context.Users
				.Include(u => u.Posts)
				.FirstOrDefault(u => u.UserId == 1);

			FeedViewModel viewModel = new FeedViewModel
			{
				currentUser = user,
				Posts = user?.Posts?.ToList()
			};

				

			Console.WriteLine($"User: {user?.Posts.Count}");	
            return View(viewModel);
        }

    }
}

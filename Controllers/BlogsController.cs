using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using HashBlogs.Models;
using HashBlogs.Data;

namespace HashBlogs.Controllers
{
	//[Route("api/[controller]")]
	//[ApiController]
    public class BlogsController : Controller
    {
		private readonly ApplicationDbContext _context;

		public BlogsController(ApplicationDbContext context)
		{
			_context  = context;
		}

        // GET: Blogs
        //[HttpGet("blogs")]
        public async Task<IActionResult> GetBlogs()
        {
			var blogs = await _context.Blogs.ToListAsync();
            return Ok(blogs);
        }

    }
}

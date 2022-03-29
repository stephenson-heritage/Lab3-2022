using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Pages_User
{
	public class IndexModel : PageModel
	{

		private readonly ILogger<IndexModel> _logger;
		private readonly StoreDBContext _context;

		public User? UserInfo;

		public IndexModel(ILogger<IndexModel> logger, StoreDBContext context)
		{
			_logger = logger;
			_context = context;
		}
		public async Task<IActionResult> OnGetAsync()
		{
			UserInfo = await _context.User.FirstOrDefaultAsync();

			return Page();
		}
	}
}

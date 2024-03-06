using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace lab_5.Pages
{
    public class Task_listModel : PageModel
    {
		[BindProperty(SupportsGet =true)]
        public List<string> Tasks { get; set; }= new List<string>();
        public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			return RedirectToPage("/Add new Task", new { T1 = Tasks });
		}
	}
}

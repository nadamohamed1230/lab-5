using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
namespace lab_5.Pages
{
    public class Add_new_TaskModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public List<string> T1 { get; set; } = new List<string>();
        [BindProperty]
		public string Task { get; set; }
		public void OnGet()
        {
            
        }
    
        public IActionResult OnPost(string Task)
        {
            T1.Add(Task);

            return RedirectToPage("/Task list", new { Tasks=T1});
        }
    }
}

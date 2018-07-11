using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConnectionTest.Pages.Connectionspages
{
    public class createModel : PageModel
    {
        private ApplicationDbContext _db;

        public createModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Connections Connection { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                _db.ConnectionItems.Add(Connection);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
        }  
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ConnectionTest.Pages.Connectionspages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Connections>MyConnections { get; set; }
        
        public async Task OnGet()
    {
        MyConnections = await _db.ConnectionItems.ToListAsync();
    }
    }
}
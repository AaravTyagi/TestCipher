using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CipherTest.Data;
using CipherTest.Models;

namespace CipherTest.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly CipherTest.Data.ApplicationDbContext _context;

        public IndexModel(CipherTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teachers.ToListAsync();
        }
    }
}

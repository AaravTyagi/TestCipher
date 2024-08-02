using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CipherTest.Data;
using CipherTest.Models;

namespace CipherTest.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Subject> Subjects { get; set; }

        public async Task OnGetAsync()
        {
            Subjects = await _context.Subjects
                .Include(s => s.TeacherSubjects)
                .ThenInclude(ts => ts.Teacher)
                .ToListAsync();
        }
    }
}


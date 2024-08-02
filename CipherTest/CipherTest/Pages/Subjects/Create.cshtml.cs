using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CipherTest.Data;
using CipherTest.Models;

namespace CipherTest.Pages.Subjects
{
    public class CreateSubjectModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Subject Subject { get; set; }

        [BindProperty]
        public List<string> Languages { get; set; } = new List<string>();

        public CreateSubjectModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Subjects.Add(Subject);
            await _context.SaveChangesAsync();

            foreach (var language in Languages)
            {
                _context.SubjectLanguages.Add(new SubjectLanguage
                {
                    SubjectId = Subject.Id,
                    Language = language
                });
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("/Subjects/Index");
        }
    }
}

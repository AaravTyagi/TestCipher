using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CipherTest.Data;
using CipherTest.Models;

namespace CipherTest.Pages.Teachers
{
    public class CreateTeacherModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Teacher Teacher { get; set; }


        public CreateTeacherModel(ApplicationDbContext context)
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

           
            //Test
            _context.Teachers.Add(Teacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Teachers/Index");
        }
    }
}

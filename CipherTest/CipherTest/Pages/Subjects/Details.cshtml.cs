﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly CipherTest.Data.ApplicationDbContext _context;

        public DetailsModel(CipherTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Subject Subject { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subjects.FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }
            else
            {
                Subject = subject;
            }
            return Page();
        }
    }
}

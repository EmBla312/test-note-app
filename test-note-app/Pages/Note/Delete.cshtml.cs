﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using test_note_app.Data;
using test_note_app.Models;

namespace test_note_app.Pages.Note
{
    public class DeleteModel : PageModel
    {
        private readonly test_note_app.Data.test_note_appContext _context;

        public DeleteModel(test_note_app.Data.test_note_appContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notes Notes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notes = await _context.Notes.FirstOrDefaultAsync(m => m.ID == id);

            if (Notes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notes = await _context.Notes.FindAsync(id);

            if (Notes != null)
            {
                _context.Notes.Remove(Notes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using test_note_app.Data;
using test_note_app.Models;

namespace test_note_app.Models
{
    public class CreateModel : PageModel
    {
        private readonly test_note_app.Data.RazorPagesNotesContext _context;

        public CreateModel(test_note_app.Data.RazorPagesNotesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Notes Notes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Notes.Add(Notes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

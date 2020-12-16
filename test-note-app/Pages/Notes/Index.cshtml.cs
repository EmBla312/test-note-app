using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using test_note_app.Data;
using test_note_app.Models;

namespace test_note_app.Models
{
    public class IndexModel : PageModel
    {
        private readonly test_note_app.Data.RazorPagesNotesContext _context;

        public IndexModel(test_note_app.Data.RazorPagesNotesContext context)
        {
            _context = context;
        }

        public IList<Notes> Notes { get;set; }

        public async Task OnGetAsync()
        {
            Notes = await _context.Notes.ToListAsync();
        }
    }
}

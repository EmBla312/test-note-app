using System;
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
    public class IndexModel : PageModel
    {
        private readonly test_note_app.Data.test_note_appContext _context;

        public IndexModel(test_note_app.Data.test_note_appContext context)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_note_app.Models;

namespace test_note_app.Data
{
    public class test_note_appContext : DbContext
    {
        public test_note_appContext (DbContextOptions<test_note_appContext> options)
            : base(options)
        {
        }

        public DbSet<test_note_app.Models.Notes> Notes { get; set; }
    }
}

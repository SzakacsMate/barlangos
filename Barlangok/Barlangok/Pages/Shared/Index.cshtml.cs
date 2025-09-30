using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlangok.Data;
using Barlangok.Models;

namespace Barlangok.Pages.Shared
{
    public class IndexModel : PageModel
    {
        private readonly Barlangok.Data.BarlangDBContext _context;

        public IndexModel(Barlangok.Data.BarlangDBContext context)
        {
            _context = context;
        }

        public IList<Barlang> Barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Barlang = await _context.Barlangok.ToListAsync();
        }
    }
}

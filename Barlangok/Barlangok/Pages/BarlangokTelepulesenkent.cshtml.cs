using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Barlangok.Data;
using Barlangok.Models;
using Microsoft.EntityFrameworkCore;

namespace Barlangok.Pages
{
    public class BarlangokTelepulesenkentModel : PageModel
    {
        private readonly Barlangok.Data.BarlangDBContext _context;

        public BarlangokTelepulesenkentModel(Barlangok.Data.BarlangDBContext context)
        {
            _context = context;
        }



        [BindProperty(SupportsGet = true)]
        public int KivalasztottBarlang { get; set; }

        public IList<string> Telepulesek { get; set; }
        public IList<Barlang> Nevek { get; set; } = default!;


        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task OnGetAsync()
        {
            Telepulesek = _context.Barlangok.Select(x => x.Telepules).Distinct().OrderBy(x => x).ToList();
            if (KivalasztottBarlang == 0)
                Nevek = await _context.Barlangok.ToListAsync();
            else
                Nevek = _context.Barlangok.Where(x => x.Nev == KivalasztottBarlang).ToList();
        }
    }
}

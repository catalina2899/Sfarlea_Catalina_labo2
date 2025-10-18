using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sfarlea_Catalina_lab2.Data;
using Sfarlea_Catalina_lab2.Models;

namespace Sfarlea_Catalina_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Sfarlea_Catalina_lab2.Data.Sfarlea_Catalina_lab2Context _context;

        public IndexModel(Sfarlea_Catalina_lab2.Data.Sfarlea_Catalina_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}

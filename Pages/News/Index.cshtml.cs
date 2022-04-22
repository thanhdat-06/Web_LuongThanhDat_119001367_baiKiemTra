#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TinTuc.Models;

namespace TinTuc.Pages_News
{
    public class IndexModel : PageModel
    {
        private readonly TinTucContext _context;

        public IndexModel(TinTucContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }

        public async Task OnGetAsync()
        {
            News = await _context.News.ToListAsync();
        }
    }
}

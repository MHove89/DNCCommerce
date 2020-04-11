using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Commerce.Domain.Entities;

namespace Commerce.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Commerce.Infrastructure.Data.ApplicationDbContext _context;

        public IndexModel(Commerce.Infrastructure.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DNCommerce.Domain.Entities;

namespace DNCommerce.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly DNCommerce.Infrastructure.Data.ApplicationDbContext _context;

        public IndexModel(DNCommerce.Infrastructure.Data.ApplicationDbContext context)
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

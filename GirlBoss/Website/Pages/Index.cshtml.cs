using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Girlboss.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db; // Just for me , only assigned once 

        public IndexModel(AppDbContext db)
        {
            _db = db;

        }

        public IList<Customer> Customers { get; private set;  } //only we can set it 

        public async Task OngetAsync()
        {
            Customers = await _db.Customers.AsNoTracking().ToListAsync(); 
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var customer = await _db.Customers.FindAsync(id); 
            if(customer != null)
            {
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync(); 
            }
            return RedirectToPage(); 
        }
    }
}

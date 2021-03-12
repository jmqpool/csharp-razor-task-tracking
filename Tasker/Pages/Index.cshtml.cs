using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<Task> Tasks;


        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context) {
            context = _context;
        }

        public void OnGet()
        {
            Tasks = _context.Tasks;
            Tasks.OrderBy(x => x.Priority);
                
        }
    }
}

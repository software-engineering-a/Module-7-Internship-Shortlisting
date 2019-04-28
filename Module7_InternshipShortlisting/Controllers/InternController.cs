using Module7_InternshipShortlisting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Module7_InternshipShortlisting.Controllers
{
    public class InternController : Controller
    {
        private Db _context;

        public InternController()
        {
            _context = new Db();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Intern
        public async Task<ActionResult> Shortlist(string searchString)
        {
            //var interns = _context.Candidates.ToList();

            var selectIntern = from s in _context.Candidates
                           select s;

            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                selectIntern = selectIntern.Where(s => s.Name.Contains(searchString));
            }

            return View(await selectIntern.AsNoTracking().ToListAsync());
        }
    }
}
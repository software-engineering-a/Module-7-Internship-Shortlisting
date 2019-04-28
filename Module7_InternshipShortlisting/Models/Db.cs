using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Module7_InternshipShortlisting.Models
{
    public class Db : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
    }
}
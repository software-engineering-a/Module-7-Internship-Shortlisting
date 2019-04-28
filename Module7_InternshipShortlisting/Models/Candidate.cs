using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Module7_InternshipShortlisting.Models
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int YearsofExperience { get; set; }
        public string City { get; set; }
        public string Degree { get; set; }
        public string DepartmentofInterest { get; set; }
        public string Institute { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Project
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [RegularExpression(@"^\(?([0-9]{3}-)\)?[-. ]?([0-9]{10})[-. ]?$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }
        public string Classification {get; set;}
        public double Price { get; set; }
        public int PageNumbers { get; set; }

    }
}

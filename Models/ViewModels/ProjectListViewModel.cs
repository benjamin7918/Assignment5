using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    //This is where we create the view model
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PageInfo PageInfo { get; set; }
        public string Type { get; set; }
    }
}

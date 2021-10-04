using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class StudentGenreViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList DiaChi { get; set; }
        public string StudentGenre { get; set; }
        public string SearchString { get; set; }
    }
}

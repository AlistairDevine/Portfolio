using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.UX.Models
{
    public class Project
    {
        public string Full_Name { get; set; }
        public string Description { get; set; }
        public string HTML_URL { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Language { get; set; }
        public bool Fork { get; set; }
    }
}

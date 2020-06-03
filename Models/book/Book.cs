using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersCCV2.Models.book
{
    public class Book
    {
        public string ISBN { get; set; }
        public string aLastName { get; set; }
        public string aFirstName { get; set; }
        public string bTitle { get; set; }
        public string edition { get; set; }
        public string pDate { get; set; }
        public string notes { get; set; }
        public string image { get; set; }
    }
}

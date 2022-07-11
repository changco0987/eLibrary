using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class borrowModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int booksInfoId { get; set; }
        public string startDate { get; set; }
        public string returnDate { get; set; }
        public string remarks { get; set; }
        public int adminId { get; set; }
    }
}

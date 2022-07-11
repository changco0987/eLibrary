using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class donateModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int booksInfoId { get; set; }
        public string recieveDate { get; set; }
        public int adminId { get; set; }
        public string remark { get; set; }
    }
}

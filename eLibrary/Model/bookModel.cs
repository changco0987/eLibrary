using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class bookModel
    {
        public int id { get; set; }
        public string bookTitle { get; set; }
        public int authorId { get; set; }
        public string yearPublished { get; set; }
        public string subject { get; set; }
        public string synopsis { get; set; }
        public string preview { get; set; }
        public int adminId { get; set; }
        public string imageName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public class adminModel
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int contact { get; set; }
        public string address { get; set; }
        public int admissionCode { get; set; }
        public int positionId { get; set; }
        public string imageName { get; set; }
    }
}

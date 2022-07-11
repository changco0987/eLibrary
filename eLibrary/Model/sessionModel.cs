using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Model
{
    public static class sessionModel
    {
        public static int userId { get; set; }
        public static string name { get; set; }
        public static string username { get; set; }
        public static int adminId { get; set; }
        public static string imageName { get; set; }
    }

    public static class editProfileSession 
    {
        public static int Id { get; set; }
        public static string name { get; set; }
        public static string email { get; set; }
        public static int contact { get; set; }
        public static string address { get; set; }
        public static string imageName { get; set; }


        public static void reset()
        {
            Id= 0;
            name = "";
            email = "";
            contact = 0;
            address = "";
            imageName = "";

        }
    }

    public static class bookSession 
    {
        public static int bookId { get; set; }
        public static string bookTitle { get; set; }
        public static int authorInfoId { get; set; }
        public static string yearPublished { get; set; }
        public static string subject { get; set; }
        public static string synopsis { get; set; }
        public static int adminId { get; set; }
        public static string imageName { get; set; }
        public static string authorName { get; set; }
    }

    public static class borrowSession 
    {
        public static string remarks { get; set; }
        public static string type { get; set; }
    }
}

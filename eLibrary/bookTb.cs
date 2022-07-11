using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLibrary.Model;
using System.Data;


namespace eLibrary
{
    public class bookTb
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateBook(bookModel book)
        {
            string query = "";
            conn.Open();
            if (book.adminId == 0 && sessionModel.adminId==0)
            {
                query = "insert into booksinfotb (booktitle, authorinfoId, yearPublished, subject, synopsis, imageName)" +
    "values('" + book.bookTitle + "'," + book.authorId + ",'" + book.yearPublished + "','" + book.subject + "','" + book.synopsis + "','" + book.imageName + "')";
            }
            else 
            {
                query = "insert into booksinfotb (booktitle, authorinfoId, yearPublished, subject, synopsis, adminId, imageName)" +
    "values('" + book.bookTitle + "'," + book.authorId + ",'" + book.yearPublished + "','" + book.subject + "','" + book.synopsis + "'," + book.adminId + ",'" + book.imageName + "')";
            }

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<bookModel> ReadBook()
        {
            conn.Open();
            string query = "select * from booksinfotb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<bookModel> model = new List<bookModel>();

            List<DataRow> allBook = dt.AsEnumerable().ToList();

            foreach (var data in allBook)
            {
                if (data[7] != System.DBNull.Value)
                {
                    var obj = new bookModel()
                    {
                        id = (int)data[0],
                        bookTitle = (string)data[1],
                        authorId = (int)data[2],
                        yearPublished = data[3].ToString(),
                        subject = (string)data[4],
                        synopsis = (string)data[5],
                        adminId = (int)data[7],
                        imageName = (string)data[8]
                    };
                    model.Add(obj);
                }
                else 
                {
                    var obj = new bookModel()
                    {
                        id = (int)data[0],
                        bookTitle = (string)data[1],
                        authorId = (int)data[2],
                        yearPublished = data[3].ToString(),
                        subject = (string)data[4],
                        synopsis = (string)data[5],
                        imageName = (string)data[8]
                    };
                    model.Add(obj);
                }



            }

            conn.Close();
            return model;

        }

        public void UpdateBook(bookModel book)
        {
            //conn.Open();
            //string query = "update booksinfotb set remarks = '" + book.remarks + "' where id = " + borrow.id + "";
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }
    }
}

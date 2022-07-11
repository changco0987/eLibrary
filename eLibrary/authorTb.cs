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
    public class authorTb
    {

        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateAuthor(authorModel author)
        {
            conn.Open();
            string query = "insert into authorinfoTb (authorName, address)" +
                "values('" + author.authorName + "','" + author.address + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<authorModel> ReadAuthor()
        {
            conn.Open();
            string query = "select * from authorinfoTb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<authorModel> model = new List<authorModel>();

            List<DataRow> allAuthor = dt.AsEnumerable().ToList();

            foreach (var data in allAuthor)
            {
                var obj = new authorModel()
                {
                    id = (int)data[0],
                    authorName = (string)data[1],
                    address = (string)data[2]
                };
                model.Add(obj);
            }

            conn.Close();
            return model;

        }

        public void UpdateAuthor(authorModel author)
        {
            //conn.Open();
            //string query = "update booksinfotb set remarks = '" + book.remarks + "' where id = " + borrow.id + "";
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }
    }
}

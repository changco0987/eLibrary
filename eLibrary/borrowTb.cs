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
    public class borrowTb
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateBorrow(borrowModel borrow)
        {
            conn.Open();
            string query = "insert into borrowtb (booksInfoId, userId, startDate, returnDate, remarks)" +
                "values(" + borrow.booksInfoId + "," + borrow.userId + ",'" + borrow.startDate + "','" + borrow.returnDate + "','"+borrow.remarks+"')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<borrowModel> ReadBorrow()
        {
            conn.Open();
            string query = "select * from borrowtb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<borrowModel> model = new List<borrowModel>();

            List<DataRow> allBorrow = dt.AsEnumerable().ToList();

            foreach (var data in allBorrow)
            {
                var obj = new borrowModel()
                {
                    id = (int)data[0],
                    booksInfoId = (int)data[1],
                    userId = (int)data[2],
                    startDate = data[3].ToString(),
                    returnDate = data[4].ToString(),
                    remarks = (string)data[5]
                };
                model.Add(obj);
            }

            conn.Close();
            return model;

        }

        public void UpdateBorrow(borrowModel borrow)
        {
            conn.Open();
            string query = "update borrowtb set remarks = '" + borrow.remarks + "', adminId = "+borrow.adminId+" where id = " + borrow.id + "";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

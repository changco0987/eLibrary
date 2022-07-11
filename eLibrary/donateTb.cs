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
    public class donateTb
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateDonate(donateModel donate)
        {
            conn.Open();
            string query = "insert into donatetb (userId, booksInfoId, recieveDate, remark)" +
                "values(" + donate.userId + "," + donate.booksInfoId + ",'" + donate.recieveDate + "','" + donate.remark + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<donateModel> ReadDonate()
        {
            conn.Open();
            string query = "select * from donatetb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<donateModel> model = new List<donateModel>();

            List<DataRow> allDonate = dt.AsEnumerable().ToList();

            foreach (var data in allDonate)
            {
                var obj = new donateModel()
                {
                    id = (int)data[0],
                    userId = (int)data[1],
                    booksInfoId = (int)data[2],
                    recieveDate = data[3].ToString(),
                    remark = (string)data[5]
                };
                model.Add(obj);
            }

            conn.Close();
            return model;

        }

        public void UpdateDonate(donateModel donate)
        {
            conn.Open();
            string query = "update donatetb set remark = '" + donate.remark + "', adminId = " + donate.adminId + " where id = " + donate.id + "";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}

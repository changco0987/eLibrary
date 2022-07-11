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
    public class adminTb
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateAdmin(adminModel admin)
        {
            conn.Open();
            string query = "insert into admintb (username, password, name, contact, address, admissionCode, positionId,imageName)" +
                "values('" + admin.username + "','" + admin.password + "','" + admin.name + "','" + admin.contact + "','" + admin.address + "'," + admin.admissionCode + ","+admin.positionId+",'"+admin.imageName+"')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<adminModel> ReadAdmin()
        {
            conn.Open();
            string query = "select * from admintb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<adminModel> model = new List<adminModel>();

            List<DataRow> allAdmin = dt.AsEnumerable().ToList();

            foreach (var data in allAdmin)
            {
                var obj = new adminModel()
                {
                    id = (int)data[0],
                    username = (string)data[1],
                    password = (string)data[2],
                    name = (string)data[3],
                    contact = (int)data[4],
                    address = (string)data[5],
                    admissionCode = (int)data[6],
                    positionId = (int)data[7],
                    imageName = (string)data[8]
                };
                model.Add(obj);
            }

            conn.Close();
            return model;

        }

        public void UpdateAdmin(adminModel admin)
        {
            conn.Open();
            string query = "update admintb set password = '" + admin.password + "' where username = '" + admin.username + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

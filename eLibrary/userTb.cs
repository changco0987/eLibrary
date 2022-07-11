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
    public class userTb
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=elibrary_db;uid=root;password=;Convert Zero Datetime=True;");
        public void CreateUser(userModel user) 
        {
            conn.Open();
            string query = "insert into usertb (username, password, name, emailAddress, contact, address,imageName)"+
                "values('"+user.username+"','"+user.password+"','"+user.name+"','"+user.emailAddress+"',"+user.contact+",'"+user.address+"','"+user.imageName+"')";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public List<userModel> ReadUser()
        {
            conn.Open();
            string query = "select * from usertb";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<userModel> model = new List<userModel>();

            List<DataRow> allUser = dt.AsEnumerable().ToList();

            foreach (var data in allUser) 
            {
                var obj = new userModel()
                {
                    id = (int)data[0],
                    username = (string)data[1],
                    password = (string)data[2],
                    name = (string)data[3],
                    emailAddress = (string)data[4],
                    contact = data[5].ToString(),
                    address = (string)data[6],
                    imageName = (string)data[7]
                };
                model.Add(obj);
            }

            conn.Close();
            return model;

        }

        public void UpdateUser(userModel user)
        {
            conn.Open();
            string query = "";
            if (user.imageName != "")
            {
                query = "update usertb set imageName = '" + user.imageName + "' where username = '" + user.username + "'";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                conn.Open();
            }

            if (editProfileSession.Id !=0)
            {
                query = "update usertb set name = '" + user.name + "', emailAddress = '"+user.emailAddress+"', contact = "+user.contact+", address = '"+user.address+"' where username = '" + user.username + "'";
            }
            else 
            {
                query = "update usertb set password = '" + user.password + "' where username = '" + user.username + "'";
            }

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}

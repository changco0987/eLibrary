using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eLibrary.Model;

namespace eLibrary
{
    public partial class Reset : Form
    {

        userModel user = new userModel();
        userTb userTb = new userTb();
        public Reset()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userlogin = new UserLogin();
            userlogin.ShowDialog();
            this.Close();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!checkField() && saveData()==true)
            {
                

                userTb.UpdateUser(user);
                MessageBox.Show("Updated Successfully!");

                this.Hide();
                var userlogin = new UserLogin();
                userlogin.ShowDialog();
                this.Close();
            }
        }
        bool saveData()
        {
            List<userModel> userModel = userTb.ReadUser();

            foreach (var data in userModel) 
            {
                if (username.Text == data.username && password.Text == data.password)
                {
                    user.username = username.Text;
                    user.password = newPassword.Text;
                    return true;
                }
                else if (username.Text == data.username && password.Text != data.password) 
                {

                    MessageBox.Show("Incorrect Password");
                    return false;
                }
            }



            MessageBox.Show("username does not exist");
            return false;
        }


        bool checkField()
        {
            if (username.Text.Trim() == String.Empty ||
            password.Text.Trim() == String.Empty ||
            newPassword.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please check information carefully!");
                return true;
            }


            return false;
        }
    }
}

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
    public partial class adminReset : Form
    {
        adminModel admin = new adminModel();
        adminTb adminTb = new adminTb();
        public adminReset()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminlogin = new adminLogin();
            adminlogin.ShowDialog();
            this.Close();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (!checkField() && saveData() == true)
            {

                    
                adminTb.UpdateAdmin(admin);
                MessageBox.Show("Updated Successfully!");

                this.Hide();
                var userlogin = new adminLogin();
                userlogin.ShowDialog();
                this.Close();
            }
        }


        bool saveData()
        {
            List<adminModel> adminModel = adminTb.ReadAdmin();

            foreach (var data in adminModel)
            {
                if (username.Text == data.username && password.Text == data.password)
                {
                    admin.username = username.Text;
                    admin.password = newPassword.Text;

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

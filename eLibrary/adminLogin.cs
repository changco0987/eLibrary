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
    public partial class adminLogin : Form
    {
        adminModel admin = new adminModel();
        public adminLogin()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signup = new adminSignup();
            signup.ShowDialog();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reset = new adminReset();
            reset.ShowDialog();
            this.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!checkField() && checkData() == true)
            {

                this.Hide();
                var homepage = new adminHomepage();
                homepage.ShowDialog();
            }
        }

        bool checkData()
        {
            adminTb adminTb = new adminTb();
            List<adminModel> adminModel = adminTb.ReadAdmin();

            foreach (var data in adminModel)
            {
                if (username.Text == data.username && password.Text == data.password)
                {
                    sessionModel.adminId = data.id;//Saved the userId
                    sessionModel.name = data.name;
                    MessageBox.Show("Log-in successfully");
                    return true;
                }
                else if (username.Text == data.username && password.Text != data.password)
                {
                    MessageBox.Show("Incorrect Password!");
                    return false;
                }
            }
            MessageBox.Show("username does not exists!");
            return false;

        }

        bool checkField()
        {

            if (username.Text.Trim() == String.Empty ||
            password.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please check information carefully!");
                return true;
            }


            return false;
        }


    }
}

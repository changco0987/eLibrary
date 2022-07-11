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
    public partial class UserLogin : Form
    {

        userModel user = new userModel();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reset = new Reset();
            reset.ShowDialog();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var goback = new Login();
            goback.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!checkField() && checkData()==true) 
            {
                

                this.Hide();
                var homepage = new Homepage();
                homepage.ShowDialog();
                this.Close();
            }
        }

        bool checkData()
        {
            userTb userTb = new userTb();
            List<userModel> userModel = userTb.ReadUser();

            foreach (var data in userModel) 
            {
                if (username.Text == data.username && password.Text == data.password)
                {
                    sessionModel.userId = data.id;//Saved the userId
                    sessionModel.name = data.name;
                    sessionModel.username = data.username;
                    sessionModel.imageName = data.imageName;
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

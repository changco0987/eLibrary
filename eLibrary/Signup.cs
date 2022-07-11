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
    public partial class Signup : Form
    {
        userModel user = new userModel();
        public Signup()
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkField() && saveData() == true)
                {

                    userTb userTb = new userTb();
                    userTb.CreateUser(user);
                    MessageBox.Show("Created Successfully!");

                    this.Hide();
                    var userlogin = new UserLogin();
                    userlogin.ShowDialog();
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Please check your information carefully!");
                return;
            }

        }

        bool saveData() 
        {
            try
            {
                user.username = username.Text;
                //This will check if the username was already taken
                userTb userTb = new userTb();
                List<userModel> userList = userTb.ReadUser();
                foreach (var data in userList)
                {
                    if (data.username == user.username)
                    {
                        MessageBox.Show("Your username is already taken");
                        return false;
                    }
                }

                user.password = password.Text;
                user.name = fname.Text + " " + lname.Text;
                user.emailAddress = emailAdd.Text;
                user.contact = contactNum.Text;
                user.address = address.Text;

                return true;
            }
            catch 
            {
                MessageBox.Show("Error, please try again");
                return false;
            }


        }

        bool checkField() 
        {
            if (password.Text == confirmPass.Text)
            {
                if (fname.Text.Trim() == String.Empty ||
                lname.Text.Trim() == String.Empty ||
                username.Text.Trim() == String.Empty ||
                password.Text.Trim() == String.Empty ||
                confirmPass.Text.Trim() == String.Empty ||
                emailAdd.Text.Trim() == String.Empty ||
                contactNum.Text.Trim() == String.Empty ||
                address.Text.Trim() == String.Empty ||
                (agreement.Checked == false))
                {
                    MessageBox.Show("Please check information carefully!");
                    return true;
                }
            }
            else 
            {
                MessageBox.Show("Please write your password carefully!");
                return true;
            }

            return false;
        }

    }
}

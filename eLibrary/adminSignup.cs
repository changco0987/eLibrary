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
    public partial class adminSignup : Form
    {
        adminModel admin = new adminModel();
        public adminSignup()
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkField() && saveData() == true)
                {
                    saveData();

                    adminTb adminTb = new adminTb();
                    adminTb.CreateAdmin(admin);
                    MessageBox.Show("Created Successfully!");

                    this.Hide();
                    var userlogin = new adminLogin();
                    userlogin.ShowDialog();
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Please check your information carefully!");
            }

        }

        List<string> adCode = new List<string>()
        {
            "902342",
            "093456",
            "127534",
            "989539",
            "092351"
        };
        bool saveData()
        {
            try
            {
                admin.username = username.Text;
                //This will check if the username was already taken
                adminTb adminTb = new adminTb();
                List<adminModel> adminList = adminTb.ReadAdmin();
                foreach (var data in adminList) 
                {
                    if (data.username == admin.username) 
                    {
                        MessageBox.Show("Your username is already taken");
                        return false;
                    }
                }

                admin.password = password.Text;
                admin.name = name.Text;
                admin.contact = Convert.ToInt32(contactNum.Text);
                admin.address = address.Text;
                admin.positionId = Convert.ToInt32(position.SelectedIndex + 1);

                foreach (var code in adCode)
                {
                    if (code==admissionCode.Text) 
                    {
                        admin.admissionCode = Convert.ToInt32(admissionCode.Text);
                        return true;
                    }
                }

                return false;

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
                if (name.Text.Trim() == String.Empty ||
                username.Text.Trim() == String.Empty ||
                password.Text.Trim() == String.Empty ||
                confirmPass.Text.Trim() == String.Empty ||
                contactNum.Text.Trim() == String.Empty ||
                address.Text.Trim() == String.Empty ||
                admissionCode.Text.Trim() == String.Empty ||
                position.Text.Trim() == String.Empty)
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

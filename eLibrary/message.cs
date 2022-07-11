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
    public partial class message : Form
    {
        userTb userTb = new userTb();   
        public message()
        {
            InitializeComponent();

            List<userModel> userList = userTb.ReadUser();
            foreach (var user in userList) 
            {
                if (sessionModel.userId == user.id) 
                {
                    messageLb.Text = "Good day, " + user.name + " we are here to inform you that your "+borrowSession.type+" request for book named \'"+bookSession.bookTitle+
                        "\' was " + borrowSession.remarks + " Hope you've enjoy using E-library";
                }
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new Homepage();
            back.ShowDialog();
        }
    }
}

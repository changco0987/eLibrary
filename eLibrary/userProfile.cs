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
    public partial class userProfile : Form
    {

        private string storagePath = Application.UserAppDataPath + @"\image_profile\";
        private int borrowCount = 0;
        private int donateCount = 0;
        public userProfile()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(sessionModel.imageName))
            {
                if (!Directory.Exists(storagePath))
                {
                    Directory.CreateDirectory(storagePath);
                }

                //This will check if the image is existing in the local storage
                if (File.Exists(storagePath + sessionModel.imageName))
                {
                    using (FileStream stream = new FileStream(storagePath + sessionModel.imageName, FileMode.Open, FileAccess.Read))
                    {
                        profilePic.Image = Image.FromStream(stream);
                        stream.Close();
                    }
                }
            }

            getAllUserInfo();
        }

        void getAllUserInfo()
        {
            userTb userTb = new userTb();

            List<userModel> userList = userTb.ReadUser();


            foreach (userModel users in userList)
            {
                if (sessionModel.userId==users.id) 
                {
                    nameLb.Text = users.name;
                    emailLb.Text = users.emailAddress;
                    contactLb.Text = users.contact.ToString();
                    addressLb.Text = users.address;

                    //This is to count user borrow
                    borrowTb borrowTb = new borrowTb();
                    List<borrowModel> borrowList = borrowTb.ReadBorrow();
                    foreach (borrowModel borrows in borrowList)
                    {
                        if (sessionModel.userId==borrows.userId && borrows.remarks=="accepted") 
                        {
                            borrowCount++;
                        }
                    }

                    borrowedLb.Text = borrowCount.ToString();

                    //This is to count user donate
                    donateTb donateTb = new donateTb();
                    List<donateModel> donateList = donateTb.ReadDonate();
                    foreach (donateModel donates in donateList) 
                    {
                        if (sessionModel.userId==donates.userId && donates.remark=="accepted") 
                        {
                            donateCount++;
                        }
                    }

                    donatedLb.Text = donateCount.ToString();
                    return;
                }
            }

        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            editProfileSession.Id = sessionModel.userId;
            editProfileSession.name = nameLb.Text;
            editProfileSession.email = emailLb.Text;
            editProfileSession.address = addressLb.Text;
            editProfileSession.contact = Convert.ToInt32(contactLb.Text);

            this.Hide();
            var openEdit = new editUserProfile();
            openEdit.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new Homepage();
            back.ShowDialog();
        }
    }



}

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
    public partial class editUserProfile : Form
    {
        private string storagePath = Application.UserAppDataPath + @"\image_profile\";
        userModel user = new userModel();
        userTb userTb = new userTb();
        public editUserProfile()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(sessionModel.imageName))
            {

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
            getUserInfo();
        }



        void getUserInfo() 
        {
            nameTb.Text = editProfileSession.name;
            emailAdd.Text = editProfileSession.email;
            address.Text = editProfileSession.address;
            contactNum.Text = editProfileSession.contact.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            editProfileSession.reset();
            this.Hide();
            var back = new userProfile();
            back.ShowDialog();
        }
        bool checkField()
        {
            if (nameTb.Text.Trim() == String.Empty ||
                emailAdd.Text.Trim() == String.Empty ||
                address.Text.Trim() == String.Empty ||
                contactNum.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill-up information carefully!");
                return true;
            }


            return false;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!checkField())
            {
                try
                {

                    if (imgName.Trim() != String.Empty)
                    {
                        File.Copy(imgOrigin, storagePath + imgName, true);
                        Thread.Sleep(500);
                    }
                    string num = contactNum.Text;

                    user.username = sessionModel.username;
                    user.name = nameTb.Text;
                    user.emailAddress = emailAdd.Text;
                    user.contact = contactNum.Text;
                    user.address = address.Text;

                    userTb.UpdateUser(user);
                    sessionModel.name = user.name;
                    sessionModel.imageName = user.imageName;
                    MessageBox.Show("Profile successfully updated!");

                    this.Hide();
                    var homepage = new Homepage();
                    homepage.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Error, pleaes check your information carefully");
                }
            }

           


        }
        string imgOrigin = "";
        string imgName = "";
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Directory.Exists(storagePath))
                {
                    Directory.CreateDirectory(storagePath);
                }

                using (OpenFileDialog open = new OpenFileDialog())
                {


                    open.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;)|*.PNG;*.JPG;*.JPEG;";//The file filter
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        imgOrigin = open.FileName;
                        imgName = Path.GetFileName(imgOrigin);
                        open.Dispose();
                        profilePic.Image = Image.FromFile(imgOrigin);
                        user.imageName = imgName;
                    }
                    else
                    {
                        return;
                    }


                }
            }
            catch
            {
                MessageBox.Show("Error Encountered!");
            }
        }
    }
}

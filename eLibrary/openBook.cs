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
    public partial class openBook : Form
    {
        private string storagePath = Application.UserAppDataPath + @"\book_image\";
        authorTb authorTb = new authorTb();
        public openBook()
        {
            InitializeComponent();
            titleTb.Text = bookSession.bookTitle;
            yearLb.Text = bookSession.yearPublished;
            subjectLb.Text = bookSession.subject;

            if (!string.IsNullOrEmpty(bookSession.imageName))
            {
                //This will check if the image is existing in the local storage
                if (File.Exists(storagePath + bookSession.imageName))
                {
                    using (FileStream stream = new FileStream(storagePath + bookSession.imageName, FileMode.Open, FileAccess.Read))
                    {
                        bookImage.Image = Image.FromStream(stream);
                        stream.Close();
                    }
                }
            }

            //this will get the author name
            List<authorModel> authorList = authorTb.ReadAuthor();
            foreach (var author in authorList)
            {
                if (bookSession.authorInfoId == author.id)
                {
                    nameLb.Text = author.authorName;
                    bookSession.authorName = author.authorName;
                }
            }

        }




        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userhomepage = new Homepage();
            userhomepage.ShowDialog();
        }

        private void synopsisBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            var openSynopsis = new synopsisPage();
            openSynopsis.ShowDialog();
            this.Close();
        }

        private void borrowedBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            var openBorrow = new borrowBooks();
            openBorrow.ShowDialog();
            this.Close();
        }


        bool mousedown;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

     
    }
}

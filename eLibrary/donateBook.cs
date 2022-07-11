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
    public partial class donateBook : Form
    {
        bookTb bookTb = new bookTb();
        bookModel book = new bookModel();
        donateTb donateTb = new donateTb();
        donateModel donate = new donateModel();
        authorModel author = new authorModel();
        authorTb authortb = new authorTb();
        List<authorModel> authorList;
        public donateBook()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homepage = new Homepage();
            homepage.ShowDialog();
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!checkField())
            {
                saveData();

                bookTb.CreateBook(book);
                List<bookModel> bookList = bookTb.ReadBook();
                foreach (var books in bookList)
                {
                    if (book.bookTitle == books.bookTitle && book.authorId == books.authorId)
                    {
                        donate.booksInfoId = books.id;
                    }
                }
                donate.userId = sessionModel.userId;
                donate.remark = "pending";
                donate.recieveDate = appointment.Value.ToString("yyyy-MM-dd");
                donateTb.CreateDonate(donate);

                MessageBox.Show("added Successfully!");

                this.Hide();
                var homepage = new Homepage();
                homepage.ShowDialog();
                this.Close();
            }
        }

        void saveData()
        {
            try
            {
                book.bookTitle = titleTb.Text;
                book.yearPublished = yearPub.Value.ToString("yyyy-MM-dd");
                book.subject = (string)subject.SelectedValue;

                author.authorName = authorTb.Text;

                //This will check if the author is already existed
                authorList = authortb.ReadAuthor();
                foreach (var data in authorList)
                {
                    if (data.authorName.ToLower() == authorTb.Text.ToLower())
                    {
                        book.authorId = data.id;
                        return;
                    }
                }

                //then if not it will add
                authortb.CreateAuthor(author);
                authorList = authortb.ReadAuthor();
                foreach (var data in authorList)
                {
                    if (data.authorName.ToLower() == authorTb.Text.ToLower())
                    {
                        book.authorId = data.id;
                        return;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Error, please try again");
            }
        }


        bool checkField()
        {
            if (titleTb.Text.Trim() == String.Empty ||
                authorTb.Text.Trim() == String.Empty ||
                (string)subject.SelectedItem == String.Empty)
            {
                MessageBox.Show("Please fill-up information carefully!");
                return true;
            }


            return false;
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

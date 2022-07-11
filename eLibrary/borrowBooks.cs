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
    public partial class borrowBooks : Form
    {
        borrowModel borrow = new borrowModel();
        bookModel book = new bookModel();

        borrowTb borrowTb = new borrowTb();
        bookTb bookTb = new bookTb();
        
        authorTb authortb = new authorTb();
        authorModel authormodel = new authorModel();

        public borrowBooks()
        {
            InitializeComponent();
            titleTb.Text = bookSession.bookTitle;
            author.Text = bookSession.authorName;
            DateTime published = DateTime.Parse(bookSession.yearPublished);
            yearPub.Value = published;
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

                borrowTb.CreateBorrow(borrow);
                MessageBox.Show("Appoitnment has been done!"+Environment.NewLine+"Check your message box of confirmrtion of librarian");

                this.Hide();
                var userhomepage = new Homepage();
                userhomepage.ShowDialog();
                this.Close();
            }
        }


        void saveData()
        {
            try
            {
                borrow.booksInfoId = bookSession.bookId;
                borrow.userId = sessionModel.userId;
                borrow.startDate = startDate.Value.ToString("yyyy-MM-dd");
                borrow.returnDate = returnDate.Value.ToString("yyyy-MM-dd");
                borrow.remarks = "pending";
                borrow.adminId = 0;

                return;
            }
            catch
            {
                MessageBox.Show("Error, please try again");
            }


        }

        bool checkField()
        {

            if (titleTb.Text.Trim() == String.Empty ||
                author.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please check information carefully!");
                return true;
            }

            return false;
        }
    }
}

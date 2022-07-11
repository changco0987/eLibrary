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
    public partial class adminHomepage : Form
    {
        bookModel book = new bookModel();
        authorModel author = new authorModel();
        borrowTb borrowTb = new borrowTb();
        userTb userTb = new userTb();
        borrowModel borrow = new borrowModel();
        authorTb authortb = new authorTb();
        bookTb booktb = new bookTb();
        donateModel donate = new donateModel();
        donateTb donateTb = new donateTb();
        private string storagePath = Application.UserAppDataPath + @"\book_image\";
        public adminHomepage()
        {
            InitializeComponent();

            usernameLb.Text = sessionModel.name;
            getBookUpdate();
            getDonatedBooks();
            this.DoubleBuffered = true;
            enableDoubleBuff(this);
        }
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        void getDonatedBooks() 
        {
            dgDonated.Rows.Clear();
            dgDonated.Refresh();
            dgDonated.Update();


            List<donateModel> donateList = donateTb.ReadDonate();
            List<userModel> userList = userTb.ReadUser();
            List<bookModel> bookList = booktb.ReadBook();
            foreach (var data in donateList)
            {
                if (data.remark == "pending")
                {
                    int id = data.id;
                    //To get the username
                    string username = "";
                    foreach (var user in userList)
                    {
                        if (user.id == data.userId)
                        {
                            username = user.username;
                        }
                    }

                    //To get the book title
                    string titleBook = "";
                    foreach (var book in bookList)
                    {
                        if (book.id == data.booksInfoId)
                        {
                            titleBook = book.bookTitle;
                        }
                    }
                    string appointment = data.recieveDate; 
                    dgDonated.Rows.Add(id, username, titleBook, appointment);
                }

            }
            this.DoubleBuffered = true;
            enableDoubleBuff(dgDonated);
        }


        void getBookUpdate() 
        {
            dgBorrowed.Rows.Clear();
            dgBorrowed.Refresh();
            dgBorrowed.Update();


            List<borrowModel> borrowList = borrowTb.ReadBorrow();
            List<userModel> userList = userTb.ReadUser();
            List<bookModel> bookList = booktb.ReadBook();
            foreach (var data in borrowList) 
            {
                if (data.remarks=="pending") 
                {
                    int id = data.id;
                    //To get the username
                    string username = "";
                    foreach (var user in userList)
                    {
                        if (user.id == data.userId)
                        {
                            username = user.username;
                        }
                    }

                    //To get the book title
                    string titleBook = "";
                    foreach (var book in bookList)
                    {
                        if (book.id == data.booksInfoId)
                        {
                            titleBook = book.bookTitle;
                        }
                    }
                    string startDate = data.startDate;
                    string returnDate = data.returnDate;
                    dgBorrowed.Rows.Add(id,username,titleBook,startDate,returnDate);
                }
                
            }
            this.DoubleBuffered = true;
            enableDoubleBuff(dgBorrowed);

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
                        filename.Text = imgName;
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

        List<authorModel> authorList;
        void saveData()
        {
            try
            {
                book.bookTitle = titleTb.Text;
                book.yearPublished = yearPub.Value.ToString("dd/MM/yyyy");
                book.subject = subjectTb.Text;
                book.synopsis = synopsisTb.Text;
                book.adminId = sessionModel.adminId;
                book.imageName = imgName;

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
                subjectTb.Text.Trim() == String.Empty ||
                synopsisTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill-up information carefully!");
                return true;
            }


            return false;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {

            if (!checkField())
            {
                saveData();


                if (imgName.Trim() != String.Empty)
                {
                    File.Copy(imgOrigin, storagePath + imgName, true);
                    Thread.Sleep(500);
                }

                booktb.CreateBook(book);

                MessageBox.Show("added Successfully!");

                this.Hide();
                var homepage = new adminHomepage();
                homepage.ShowDialog();
                this.Close();
            }

        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            sessionModel.adminId = 0;
            sessionModel.userId = 0;
            this.Hide();
            var adminlogin = new adminLogin();
            adminlogin.ShowDialog();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            addBtn.BackColor = Color.LimeGreen;
            donateBtn.BackColor = Color.PaleGreen;
            borrowedBtn.BackColor = Color.PaleGreen;
        }

        private void borrowedBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            addBtn.BackColor = Color.PaleGreen;
            donateBtn.BackColor = Color.PaleGreen;
            borrowedBtn.BackColor = Color.LimeGreen;
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            addBtn.BackColor = Color.PaleGreen;
            donateBtn.BackColor = Color.LimeGreen;
            borrowedBtn.BackColor = Color.PaleGreen;
        }

        private void dgBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var borrowId = dgBorrowed.Rows[e.RowIndex].Cells[0].Value;
                int clickedCell = e.ColumnIndex;
                if (clickedCell==5) 
                {
                    borrow.id = Convert.ToInt32(borrowId);
                    borrow.remarks = "accepted";
                    borrow.adminId = sessionModel.adminId;
                    borrowTb.UpdateBorrow(borrow);
                    getBookUpdate();
                }
                else if (clickedCell==6) 
                {
                    borrow.id = Convert.ToInt32(borrowId);
                    borrow.remarks = "decline";
                    borrow.adminId = sessionModel.adminId;
                    borrowTb.UpdateBorrow(borrow);
                    getBookUpdate();
                }

            }
            
        }

        private void dgDonated_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var donateId = dgDonated.Rows[e.RowIndex].Cells[0].Value;
                int clickedCell = e.ColumnIndex;
                if (clickedCell == 4)
                {
                    donate.id = Convert.ToInt32(donateId);
                    donate.remark = "accepted";
                    donate.adminId = sessionModel.adminId;
                    donateTb.UpdateDonate(donate);
                    getDonatedBooks();
                }
                else if (clickedCell == 5)
                {
                    donate.id = Convert.ToInt32(donateId);
                    donate.remark = "decline";
                    donate.adminId = sessionModel.adminId;
                    donateTb.UpdateDonate(donate);
                    getDonatedBooks();
                }

            }
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

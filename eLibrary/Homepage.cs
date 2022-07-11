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
    public partial class Homepage : Form
    {
        authorTb authorTb = new authorTb();
        borrowTb borrowTb = new borrowTb();
        donateTb donateTb = new donateTb();
        bookTb bookTb = new bookTb();

        private string storagePath = Application.UserAppDataPath + @"\image_profile\";
        private bool isCollapsed;
        private int signal = 0;
        public Homepage()
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

            usernameLb.Text = sessionModel.name;
            getBooks();
            getMyBook();
            this.DoubleBuffered = true;
            enableDoubleBuff(this);
        }

        void getMyBook() 
        {
            List<donateModel> donateList = donateTb.ReadDonate();
            List<borrowModel> borrowList = borrowTb.ReadBorrow();
            List<bookModel> bookList = bookTb.ReadBook();
            foreach (var myBorrow in borrowList)
            {
                if (myBorrow.userId == sessionModel.userId) 
                {
                    int bookId = myBorrow.id;
                    string title = "";
                    //This will get the book info
                    foreach (var myBooks in bookList) 
                    {
                        if (myBooks.id == myBorrow.booksInfoId) 
                        {
                            title = myBooks.bookTitle;

                        }
                    }

                    if (myBorrow.remarks == "accepted") 
                    {
                        dgReturn.Rows.Add(id,title);
                    }

                    dgMsg.Rows.Add(id, "Message - for your borrowed Books", title, myBorrow.remarks, "borrow");
                    dgRecent.Rows.Add(id,title);

                }

            }

            foreach (var myDonate in donateList) 
            {
                if (myDonate.userId == sessionModel.userId)
                {
                    int bookId = myDonate.id;
                    string title = "";
                    //This will get the book info
                    foreach (var myBooks in bookList)
                    {
                        if (myBooks.id == myDonate.booksInfoId)
                        {
                            title = myBooks.bookTitle;

                        }
                    }

                    if (myDonate.remark == "accepted")
                    {
                        dgDonated.Rows.Add(id, title);
                    }

                    dgMsg.Rows.Add(id, "Message - for your donated books", title, myDonate.remark,"donate");
                    dgRecent.Rows.Add(id, title);

                }
            }


            this.DoubleBuffered = true;
            enableDoubleBuff(dgRecent);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (signal == 1)
            {
                //MoreBtn
                if (isCollapsed)
                {
                    MoreBtn.Height += 10;
                    if (MoreBtn.Size == MoreBtn.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    MoreBtn.Height -= 10;
                    if (MoreBtn.Size == MoreBtn.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }
            else if (signal==2) 
            {
                //InstructionExpand1
                if (isCollapsed)
                {
                    exp1.Height += 10;
                    if (exp1.Size == exp1.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    exp1.Height -= 10;
                    if (exp1.Size == exp1.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }
            else if (signal==3) 
            {
                //InstructionExpand3
                if (isCollapsed)
                {
                    exp2.Height += 10;
                    if (exp2.Size == exp2.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    exp2.Height -= 10;
                    if (exp2.Size == exp2.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }
            else if (signal==4) 
            {
                //InstructionExpand4
                if (isCollapsed)
                {
                    exp3.Height += 10;
                    if (exp3.Size == exp3.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    exp3.Height -= 10;
                    if (exp3.Size == exp3.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }
            else if (signal==5) 
            {
                //InstructionExpand5
                if (isCollapsed)
                {
                    exp4.Height += 10;
                    if (exp4.Size == exp4.MaximumSize)
                    {
                        timer1.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    exp4.Height -= 10;
                    if (exp4.Size == exp4.MinimumSize)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                    }
                }
            }

        }


        void getBooks() 
        {
            dgBooks.Rows.Clear();
            dgBooks.Refresh();
            dgBooks.Update();
            bookTb bookTb = new bookTb();

            List<bookModel> bookList = bookTb.ReadBook();
            foreach (var data in bookList) 
            {
                string authorName = "";
                int id = data.id;
                string title = data.bookTitle;
                string yearPub = data.yearPublished;
                List<authorModel> autorList = authorTb.ReadAuthor();
                foreach (var author in autorList) 
                {
                    if (data.authorId == author.id) 
                    {
                        authorName = author.authorName;
                    }
                }
                dgBooks.Rows.Add(id, title, authorName, yearPub);
            }

            this.DoubleBuffered = true;
            enableDoubleBuff(dgBooks);


        }
        private void button5_Click(object sender, EventArgs e)
        {
            signal = 1;
            timer1.Start();
        }

        void btnColorIndicator() 
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //home/recent visit
                //color if selected
                recentvisitBtn.BackColor = Color.NavajoWhite;
                homepageBtn.BackColor = Color.LimeGreen;

                //Default color if unselected
                recentdonateBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                booksBtn.BackColor = Color.PaleGreen;
                donateBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                tosBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                //recent donated
                //color if selected
                recentdonateBtn.BackColor = Color.NavajoWhite;
                

                //Default color if unselected
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                booksBtn.BackColor = Color.PaleGreen;
                donateBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                tosBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                //recent returned
                //color if selected
                recentreturnedBtn.BackColor = Color.NavajoWhite;
                

                //Default color if unselected
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentdonateBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                booksBtn.BackColor = Color.PaleGreen;
                donateBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                tosBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                //books
                //color if selected
                booksBtn.BackColor = Color.LimeGreen;



                //Default color if unselected
                recentdonateBtn.BackColor = Color.PapayaWhip;
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                donateBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                tosBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                //help
                //color if selected
                helpBtn.BackColor = Color.YellowGreen;


                //Default color if unselected
                recentdonateBtn.BackColor = Color.PapayaWhip;
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                booksBtn.BackColor = Color.PaleGreen;


                tosBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                //term of services
                //color if selected
                tosBtn.BackColor = Color.YellowGreen;


                //Default color if unselected
                recentdonateBtn.BackColor = Color.PapayaWhip;
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                booksBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                msgBtn.BackColor = Color.LimeGreen;
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                //message
                //color if selected
                msgBtn.BackColor = Color.YellowGreen;


                //Default color if unselected
                recentdonateBtn.BackColor = Color.PapayaWhip;
                recentvisitBtn.BackColor = Color.PapayaWhip;
                recentreturnedBtn.BackColor = Color.PapayaWhip;
                homepageBtn.BackColor = Color.PaleGreen;
                booksBtn.BackColor = Color.PaleGreen;

                helpBtn.BackColor = Color.LimeGreen;
                tosBtn.BackColor = Color.LimeGreen;
            }
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnColorIndicator();
        }
        private void recentvisitBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnColorIndicator();
 
        }

        private void recentdonateBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnColorIndicator();
        }

        private void recentreturnedBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            btnColorIndicator();
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            btnColorIndicator();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            btnColorIndicator();
        }

        private void tosBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
            btnColorIndicator();
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
            btnColorIndicator();
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var donate = new donateBook();
            donate.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signal = 2;
            timer1.Start();
        }

        private void expand2_Click(object sender, EventArgs e)
        {
            signal = 3;
            timer1.Start();
        }

        private void expand3_Click(object sender, EventArgs e)
        {
            signal = 4;
            timer1.Start();
        }

        private void expand4_Click(object sender, EventArgs e)
        {
            signal = 5;
            timer1.Start();
        }

        bool mousedown;


        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            sessionModel.userId = 0;

            this.Hide();
            var userlogin = new UserLogin();
            userlogin.ShowDialog();
        }

        private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex <= dgBooks.Rows.Count)
            {
                var bookId = dgBooks.Rows[e.RowIndex].Cells[0].Value;


                bookTb books = new bookTb();
                List<bookModel> bookList = books.ReadBook();
                foreach (var data in bookList)
                {
                    if (data.id == Convert.ToInt32(bookId))
                    {
                        bookSession.bookId = data.id;
                        bookSession.bookTitle = data.bookTitle;
                        bookSession.authorInfoId = data.authorId;
                        bookSession.subject = data.subject;
                        bookSession.yearPublished = data.yearPublished;
                        bookSession.synopsis = data.synopsis;
                        bookSession.imageName = data.imageName;


                        this.Hide();

                        var openBook = new openBook();
                        openBook.ShowDialog();
                    }
                }
            }
        }

        private void dgMsg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = dgMsg.Rows[e.RowIndex].Cells[2].Value;
            var remarks = dgMsg.Rows[e.RowIndex].Cells[3].Value;
            var type = dgMsg.Rows[e.RowIndex].Cells[4].Value;
            bookSession.bookTitle = title.ToString();
            borrowSession.remarks = remarks.ToString();
            borrowSession.type = type.ToString();

            this.Hide();

            var openMsg = new message();
            openMsg.ShowDialog();
          
        }


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

        private void dgRecent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewColumn column in dgRecent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openProfile = new userProfile();
            openProfile.ShowDialog();
            return;
        }
    }
}

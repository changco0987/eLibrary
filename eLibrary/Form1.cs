namespace eLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userlogin = new UserLogin();
            userlogin.ShowDialog();
            this.Close();
        }

        private void adminBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminlogin = new adminLogin();
            adminlogin.ShowDialog();
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
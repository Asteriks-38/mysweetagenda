using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysweetagenda
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        bool move;
        int MovX, MovY;
        private void loginpanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void loginpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 207, 207);
            loginpanel.BackColor = Color.FromArgb(254, 239, 224);
            loginBtn.BackColor = Color.FromArgb(204, 128, 132);
            
        
        }

        private void loginMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_MouseMove(object sender, MouseEventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(90, 134, 173);
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.FromArgb(204, 128, 132);
        }

        private void loginpanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}

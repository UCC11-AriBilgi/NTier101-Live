using NTier101_Live.BLL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmLogin : Form
    {
        datUserBLL datUserBLL = new datUserBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btonLogin_Click(object sender, EventArgs e)
        {
            datUser datUser = new datUser();

            datUser = datUserBLL.searchUser(tboxUserName.Text, tboxUserPassw.Text);

            if (datUser.UserName == null || datUser.UserPassw == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz....");
            }
            else
            {
                frmMain frmMain = new frmMain();

                frmMain.ShowDialog();

            }
        }
    }
}

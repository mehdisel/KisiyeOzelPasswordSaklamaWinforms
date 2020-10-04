using Passwords.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SiteModel site = new SiteModel())
            {
                if (site.Users.Where(x=>x.UserName==txtLogin.Text&&x.Password.PasswordName==txtPassword.Text).Any())
                {
                    frmMain frmMain = new frmMain();
                    Properties.Settings.Default.IDLoginUser=  site.Users.Where(x => x.UserName == txtLogin.Text && x.Password.PasswordName == txtPassword.Text).FirstOrDefault().ID;
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
            }
            
           
            
        }

    }
}

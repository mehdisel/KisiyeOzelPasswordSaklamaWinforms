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
    public partial class frmHistory : Form
    {
        public frmHistory(int _siteID)
        {
            InitializeComponent();
            SiteID = _siteID;
        }
        public int SiteID { get; private set; }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            using (SiteModel context=new SiteModel())
            {
                gridControl1.DataSource = context.ChangeHistories.Where(x => x.IDSites == SiteID).ToList();
            }
        }
    }
}

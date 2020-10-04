using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<ListViewModel> siteler;
        private void frmMain_Load(object sender, EventArgs e)
        {
            using (SiteModel context=new SiteModel())
            {
                siteler=context.Sites.Select(x => new ListViewModel{ SiteName = x.SiteName.SiteAdress, SiteUserName = x.Name.UserName, Mail = x.Email.EMailAdress, PW = x.Password.PasswordName }).ToList();
                gridControl1.DataSource = new BindingSource(siteler,"");
                
            }
            //this.TopMost = true;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.ShowDialog();
            using (SiteModel context = new SiteModel())
            {
                siteler = context.Sites.Select(x => new ListViewModel { SiteName = x.SiteName.SiteAdress, SiteUserName = x.Name.UserName, Mail = x.Email.EMailAdress, PW = x.Password.PasswordName }).ToList();
            }
            gridControl1.DataSource = new BindingSource(siteler, "");
            gridView1.Columns.Clear();
            gridView1.PopulateColumns();
            gridView1.RefreshData();
        }



        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

                Clipboard.SetText(gridView1.GetFocusedValue().ToString());
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName != "PW") return;
            e.DisplayText = "֎֎֎֎֎֎֎֎";
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}

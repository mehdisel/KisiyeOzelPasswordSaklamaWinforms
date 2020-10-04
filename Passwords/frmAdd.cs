using DevExpress.XtraEditors;
using Passwords.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        List<string> allSites;
        List<string> allSiteUserNames;
        List<string> allMails;
        List<string> allPasswords;
        bool isNew=false;
        private void GetData()
        {
            using (SiteModel context = new SiteModel())
            {
                cmbSiteNames.Properties.Items.Clear();
                cmbUserNames.Properties.Items.Clear();
                cmbMailAdresses.Properties.Items.Clear();

                allSites = context.SiteNames.Select(x => x.SiteAdress).ToList();
                cmbSiteNames.Properties.Items.AddRange(allSites);
                allSiteUserNames = context.Names.Select(x => x.UserName).ToList();
                cmbUserNames.Properties.Items.AddRange(allSiteUserNames);
                allMails = context.Emails.Select(x => x.EMailAdress).ToList();
                cmbMailAdresses.Properties.Items.AddRange(allMails);
                allPasswords = context.Passwords.Select(x => x.PasswordName).ToList();
            }
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private SiteName CheckOrAddSite()
        {
            using (SiteModel context=new SiteModel())
            {
                if (context.SiteNames.Where(x=>x.SiteAdress==cmbSiteNames.Text).Any())
                {
                    return context.SiteNames.Where(x => x.SiteAdress == cmbSiteNames.Text).FirstOrDefault();
                }
                else
                {
                    SiteName siteName = new SiteName();
                    siteName.SiteAdress = cmbSiteNames.Text;
                    context.SiteNames.Add(siteName);
                    context.SaveChanges();
                    return siteName;
                }
            }
            
        }
        private Email CheckOrAddMail()
        {
            using (SiteModel context = new SiteModel())
            {
                if (context.Emails.Where(x => x.EMailAdress == cmbMailAdresses.Text).Any())
                {
                    return context.Emails.Where(x => x.EMailAdress == cmbMailAdresses.Text).FirstOrDefault();
                }
                else
                {
                    Email newMail = new Email();
                    newMail.EMailAdress = cmbMailAdresses.Text;
                    context.Emails.Add(newMail);
                    context.SaveChanges();
                    return newMail;
                }
            }

        }
        private Name CheckOrAddUserName()
        {
            using (SiteModel context = new SiteModel())
            {
                if (context.Names.Where(x => x.UserName == cmbUserNames.Text).Any())
                {
                    return context.Names.Where(x => x.UserName == cmbUserNames.Text).FirstOrDefault();
                }
                else
                {
                    Name newName = new Name();
                    newName.UserName = cmbUserNames.Text;
                    context.Names.Add(newName);
                    context.SaveChanges();
                    return newName;
                }
            }

        }
        private Password CheckOrAddPassword()
        {
            using (SiteModel context = new SiteModel())
            {
                if (context.Passwords.Where(x => x.PasswordName == txtPassword.Text).Any())
                {
                    return context.Passwords.Where(x => x.PasswordName == txtPassword.Text).FirstOrDefault();
                }
                else
                {
                    Password newPassword = new Password();
                    newPassword.PasswordName = txtPassword.Text;
                    context.Passwords.Add(newPassword);
                    context.SaveChanges();
                    return newPassword;
                }
            }

        }
        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSiteNames.Text) || string.IsNullOrEmpty(txtPassword.Text)|| string.IsNullOrEmpty(cmbMailAdresses.Text))
            {
                MessageBox.Show("site veya password eksik olamaz");
                return;
            }
            try
            {
                using (SiteModel context = new SiteModel())
                {
                    SiteName currentSite = CheckOrAddSite();
                    Email currentMail = CheckOrAddMail();
                    Name currentName = CheckOrAddUserName();
                    Password currentPassword = CheckOrAddPassword();
                    Models.Site site;
                    if (isNew)
                    {

                        site = new Models.Site();
                        site.IDSiteName = currentSite.ID;
                        site.IDEmail = currentMail.ID;
                        site.IDPassword = currentPassword.ID;
                        site.IDSiteUserName = currentName.ID;
                        site.Notes = memoNotes.Text;
                        site.IDAppUser = Properties.Settings.Default.IDLoginUser;
                   
                        context.Sites.Add(site);
                        context.SaveChanges();
                        ClearControls();
                    }
                    else
                    {
                        site = context.Sites.Where(x => x.IDSiteName == currentSite.ID && x.IDSiteUserName == currentName.ID && x.IDEmail == currentMail.ID).FirstOrDefault();
                        site.IDPassword = currentPassword.ID;
                        site.Notes = memoNotes.Text;
                        site.IDAppUser = Properties.Settings.Default.IDLoginUser;
                        context.SaveChanges();
                        ClearControls();
                    }
                    GetData();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ClearControls()
        {
            cmbSiteNames.Text = string.Empty;
            cmbUserNames.Text = string.Empty;
            cmbMailAdresses.Text = string.Empty;
            txtPassword.Text = string.Empty;
            btnAddorUpdate.Text = "ADD";
        }



        private void cmbSiteNames_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SiteModel context=new SiteModel())
            {
                isNew = !context.Sites.Where(x => x.SiteName.SiteAdress==cmbSiteNames.Text && x.Name.UserName==cmbUserNames.Text && x.Email.EMailAdress==cmbMailAdresses.Text).Any();

                if (sender is ComboBoxEdit)
                {
                    ComboBoxEdit comboBoxEdit = sender as ComboBoxEdit;
                    Models.Site selectedSite;
                    switch (comboBoxEdit.Name)
                    {
                        case "cmbSiteNames":
                            if (context.Sites.Where(x => x.SiteName.SiteAdress==cmbSiteNames.Text).Any())
                            {
                                selectedSite = context.Sites.Where(x => x.SiteName.SiteAdress == cmbSiteNames.Text).FirstOrDefault();
                                cmbUserNames.Text = selectedSite.Name == null ? string.Empty : selectedSite.Name.UserName;
                                cmbMailAdresses.Text = selectedSite.Email == null ? string.Empty : selectedSite.Email.EMailAdress;
                                txtPassword.Text = selectedSite.Password.PasswordName;
                            }
                            else
                            {
                                ClearControlsAfterTabIndex(comboBoxEdit.TabIndex);
                            }
                            break;
                        case "cmbMailAdresses":
                            if (context.Sites.Where(x => x.SiteName.SiteAdress==cmbSiteNames.Text && x.Email.EMailAdress==cmbMailAdresses.Text).Any())
                            {
                               
                                selectedSite = context.Sites.Where(x => x.SiteName.SiteAdress == cmbSiteNames.Text && x.Email.EMailAdress == cmbMailAdresses.Text).FirstOrDefault();
                                cmbUserNames.Text = selectedSite.Name == null ? string.Empty : selectedSite.Name.UserName;
                                cmbMailAdresses.Text = selectedSite.Email == null ? string.Empty : selectedSite.Email.EMailAdress;
                                txtPassword.Text = selectedSite.Password.PasswordName;
                            }
                            else
                            {
                                ClearControlsAfterTabIndex(comboBoxEdit.TabIndex);
                            }
                            break;
                        case "cmbUserNames":
                            if (context.Sites.Where(x => x.SiteName.SiteAdress==cmbSiteNames.Text && x.Name.UserName==cmbUserNames.Text && x.Email.EMailAdress==cmbMailAdresses.Text).Any())
                            {
                                selectedSite = context.Sites.Where(x => x.SiteName.SiteAdress == cmbSiteNames.Text && x.Email.EMailAdress == cmbMailAdresses.Text).FirstOrDefault();
                                cmbUserNames.Text = selectedSite.Name == null ? string.Empty : selectedSite.Name.UserName;
                                cmbMailAdresses.Text = selectedSite.Email == null ? string.Empty : selectedSite.Email.EMailAdress;
                                txtPassword.Text = selectedSite.Password.PasswordName;
                            }
                            else
                            {
                                ClearControlsAfterTabIndex(comboBoxEdit.TabIndex);
                            }
                            break;
                        default:
                            break;
                    }

                }

                if (isNew)
                {
                    btnAddorUpdate.Text = "ADD";

                }
                else
                {
                    btnAddorUpdate.Text = "UPDATE";
                }

            }


           
                //bool isNewSite = s;
                //bool isNewMail = allMails.Contains(cmbMailAdresses.Text);
                //bool isNewUserName = allSiteUserNames.Contains(cmbUserNames.Text);

                //if (isNewSite && isNewMail&& isNewUserName)
                //{
                //    isNew = false;
                //    btnAddorUpdate.Text = "UPDATE";

                //}
                //else
                //{
                //    isNew = true;
                //    btnAddorUpdate.Text = "ADD";
                //}
            

        }
        private void ClearControlsAfterTabIndex (int tabindex)
        {
      
            //Sıralamayı designer'dan yapın.
            foreach (Control item in layoutControl1.Controls)
            {
                if (item is ComboBoxEdit || item is TextEdit)
                {
                    if (item.TabIndex > tabindex)
                    {
                        item.Text = string.Empty;
                    }
                }
            }
         

        }
    }
}

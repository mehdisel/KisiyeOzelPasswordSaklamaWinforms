namespace Passwords
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbSiteNames = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbMailAdresses = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbUserNames = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnAddorUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNames = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.memoNotes = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSiteNames.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMailAdresses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserNames.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbSiteNames);
            this.layoutControl1.Controls.Add(this.cmbMailAdresses);
            this.layoutControl1.Controls.Add(this.cmbUserNames);
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.btnAddorUpdate);
            this.layoutControl1.Controls.Add(this.memoNotes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(539, 345);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbSiteNames
            // 
            this.cmbSiteNames.Location = new System.Drawing.Point(61, 12);
            this.cmbSiteNames.Name = "cmbSiteNames";
            this.cmbSiteNames.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSiteNames.Size = new System.Drawing.Size(466, 20);
            this.cmbSiteNames.StyleController = this.layoutControl1;
            this.cmbSiteNames.TabIndex = 4;
            this.cmbSiteNames.SelectedValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            this.cmbSiteNames.EditValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            // 
            // cmbMailAdresses
            // 
            this.cmbMailAdresses.Location = new System.Drawing.Point(61, 36);
            this.cmbMailAdresses.Name = "cmbMailAdresses";
            this.cmbMailAdresses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMailAdresses.Size = new System.Drawing.Size(466, 20);
            this.cmbMailAdresses.StyleController = this.layoutControl1;
            this.cmbMailAdresses.TabIndex = 5;
            this.cmbMailAdresses.SelectedValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            this.cmbMailAdresses.EditValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            // 
            // cmbUserNames
            // 
            this.cmbUserNames.Location = new System.Drawing.Point(61, 60);
            this.cmbUserNames.Name = "cmbUserNames";
            this.cmbUserNames.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserNames.Size = new System.Drawing.Size(466, 20);
            this.cmbUserNames.StyleController = this.layoutControl1;
            this.cmbUserNames.TabIndex = 6;
            this.cmbUserNames.SelectedValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            this.cmbUserNames.EditValueChanged += new System.EventHandler(this.cmbSiteNames_SelectedValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(466, 20);
            this.txtPassword.StyleController = this.layoutControl1;
            this.txtPassword.TabIndex = 7;
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.Location = new System.Drawing.Point(12, 311);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(515, 22);
            this.btnAddorUpdate.StyleController = this.layoutControl1;
            this.btnAddorUpdate.TabIndex = 8;
            this.btnAddorUpdate.Text = "Add";
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lblNames,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(539, 345);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbSiteNames;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem1.Text = "Site";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(46, 13);
            // 
            // lblNames
            // 
            this.lblNames.Control = this.cmbUserNames;
            this.lblNames.Location = new System.Drawing.Point(0, 48);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(519, 24);
            this.lblNames.Text = "Name";
            this.lblNames.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPassword;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem4.Text = "Password";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAddorUpdate;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 299);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(519, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbMailAdresses;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem3.Text = "Mail";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(46, 13);
            // 
            // memoNotes
            // 
            this.memoNotes.Location = new System.Drawing.Point(61, 108);
            this.memoNotes.Name = "memoNotes";
            this.memoNotes.Size = new System.Drawing.Size(466, 199);
            this.memoNotes.StyleController = this.layoutControl1;
            this.memoNotes.TabIndex = 9;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.memoNotes;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(519, 203);
            this.layoutControlItem2.Text = "Notes";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(46, 13);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 345);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSiteNames.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMailAdresses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserNames.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnAddorUpdate;
        private DevExpress.XtraLayout.LayoutControlItem lblNames;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSiteNames;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserNames;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMailAdresses;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.MemoEdit memoNotes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
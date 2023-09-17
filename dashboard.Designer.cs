namespace Login_And_Register___Modern_UI
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.bbTitle = new System.Windows.Forms.Label();
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFormMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFormClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain.SuspendLayout();
            this.cmsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnExit.Location = new System.Drawing.Point(722, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // bbTitle
            // 
            this.bbTitle.AutoSize = true;
            this.bbTitle.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(84)))), ((int)(((byte)(174)))));
            this.bbTitle.Location = new System.Drawing.Point(291, -2);
            this.bbTitle.Name = "bbTitle";
            this.bbTitle.Size = new System.Drawing.Size(140, 27);
            this.bbTitle.TabIndex = 6;
            this.bbTitle.Text = "Dashboard";
            // 
            // MnuMain
            // 
            this.MnuMain.AllowItemReorder = true;
            this.MnuMain.ContextMenuStrip = this.cmsForm;
            this.MnuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuOther});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(751, 25);
            this.MnuMain.TabIndex = 7;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu,
            this.MnuFileOpen,
            this.MnuFileSave,
            this.toolStripMenuItem1,
            this.MnuFileExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(42, 21);
            this.MnuFile.Text = "&File";
            // 
            // Mnu
            // 
            this.Mnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileNew,
            this.MnuFileProject});
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(180, 22);
            this.Mnu.Text = "&File";
            // 
            // MnuFileNew
            // 
            this.MnuFileNew.Name = "MnuFileNew";
            this.MnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuFileNew.Size = new System.Drawing.Size(197, 22);
            this.MnuFileNew.Text = "New &File";
            // 
            // MnuFileProject
            // 
            this.MnuFileProject.Name = "MnuFileProject";
            this.MnuFileProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MnuFileProject.Size = new System.Drawing.Size(197, 22);
            this.MnuFileProject.Text = "New &Project";
            // 
            // MnuFileOpen
            // 
            this.MnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.folderToolStripMenuItem});
            this.MnuFileOpen.Name = "MnuFileOpen";
            this.MnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.MnuFileOpen.Text = "&Open";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // MnuFileSave
            // 
            this.MnuFileSave.Name = "MnuFileSave";
            this.MnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.MnuFileSave.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuFileExit
            // 
            this.MnuFileExit.Name = "MnuFileExit";
            this.MnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.MnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.MnuFileExit.Text = "&Exit";
            this.MnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // MnuOther
            // 
            this.MnuOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEditInfor,
            this.MnuEditHelp});
            this.MnuOther.Name = "MnuOther";
            this.MnuOther.Size = new System.Drawing.Size(56, 21);
            this.MnuOther.Text = "&Other";
            // 
            // MnuEditInfor
            // 
            this.MnuEditInfor.Name = "MnuEditInfor";
            this.MnuEditInfor.Size = new System.Drawing.Size(180, 22);
            this.MnuEditInfor.Text = "&Imforamtion";
            // 
            // MnuEditHelp
            // 
            this.MnuEditHelp.Name = "MnuEditHelp";
            this.MnuEditHelp.Size = new System.Drawing.Size(180, 22);
            this.MnuEditHelp.Text = "&Help";
            // 
            // cmsForm
            // 
            this.cmsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFormMinimize,
            this.cmsFormClose});
            this.cmsForm.Name = "cmsForm";
            this.cmsForm.Size = new System.Drawing.Size(124, 48);
            // 
            // cmsFormMinimize
            // 
            this.cmsFormMinimize.Name = "cmsFormMinimize";
            this.cmsFormMinimize.Size = new System.Drawing.Size(180, 22);
            this.cmsFormMinimize.Text = "Minimize";
            this.cmsFormMinimize.Click += new System.EventHandler(this.cmsFormMinimize_Click);
            // 
            // cmsFormClose
            // 
            this.cmsFormClose.Name = "cmsFormClose";
            this.cmsFormClose.Size = new System.Drawing.Size(180, 22);
            this.cmsFormClose.Text = "Close ";
            this.cmsFormClose.Click += new System.EventHandler(this.cmsFormClose_Click);
            // 
            // dashboard
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(751, 460);
            this.Controls.Add(this.bbTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.MnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MnuMain;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.cmsForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label bbTitle;
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem MnuFileProject;
        private System.Windows.Forms.ToolStripMenuItem MnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MnuOther;
        private System.Windows.Forms.ToolStripMenuItem MnuEditInfor;
        private System.Windows.Forms.ToolStripMenuItem MnuEditHelp;
        private System.Windows.Forms.ContextMenuStrip cmsForm;
        private System.Windows.Forms.ToolStripMenuItem cmsFormMinimize;
        private System.Windows.Forms.ToolStripMenuItem cmsFormClose;
    }
}
﻿namespace WhatsMore
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbSending = new System.Windows.Forms.ProgressBar();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuLanguage,
            this.mnuHelp});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // mnuFile
            // 
            resources.ApplyResources(this.mnuFile, "mnuFile");
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveAs,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            // 
            // mnuSaveAs
            // 
            resources.ApplyResources(this.mnuSaveAs, "mnuSaveAs");
            this.mnuSaveAs.Enabled = global::WhatsMore.Properties.Settings.Default.ControlsEnabled;
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Click += new System.EventHandler(this.MnuSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mnuExit
            // 
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // mnuEdit
            // 
            resources.ApplyResources(this.mnuEdit, "mnuEdit");
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfig});
            this.mnuEdit.Name = "mnuEdit";
            // 
            // mnuConfig
            // 
            resources.ApplyResources(this.mnuConfig, "mnuConfig");
            this.mnuConfig.Enabled = global::WhatsMore.Properties.Settings.Default.ControlsEnabled;
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Click += new System.EventHandler(this.MnuConfig_Click);
            // 
            // mnuLanguage
            // 
            resources.ApplyResources(this.mnuLanguage, "mnuLanguage");
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuSpanish});
            this.mnuLanguage.Enabled = global::WhatsMore.Properties.Settings.Default.ControlsEnabled;
            this.mnuLanguage.Name = "mnuLanguage";
            // 
            // mnuEnglish
            // 
            resources.ApplyResources(this.mnuEnglish, "mnuEnglish");
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Click += new System.EventHandler(this.MnuEnglish_Click);
            // 
            // mnuSpanish
            // 
            resources.ApplyResources(this.mnuSpanish, "mnuSpanish");
            this.mnuSpanish.Name = "mnuSpanish";
            this.mnuSpanish.Click += new System.EventHandler(this.MnuSpanish_Click);
            // 
            // mnuHelp
            // 
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            // 
            // mnuAbout
            // 
            resources.ApplyResources(this.mnuAbout, "mnuAbout");
            this.mnuAbout.Enabled = global::WhatsMore.Properties.Settings.Default.ControlsEnabled;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pbSending);
            this.groupBox1.Controls.Add(this.txtNumbers);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pbSending
            // 
            resources.ApplyResources(this.pbSending, "pbSending");
            this.pbSending.Name = "pbSending";
            // 
            // txtNumbers
            // 
            resources.ApplyResources(this.txtNumbers, "txtNumbers");
            this.txtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumbers.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::WhatsMore.Properties.Settings.Default, "isSending", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = global::WhatsMore.Properties.Settings.Default.isSending;
            this.txtNumbers.TextChanged += new System.EventHandler(this.TxtNumbers_TextChanged);
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumbers_KeyPress);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbSending;
        private System.Windows.Forms.ToolStripMenuItem mnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuSpanish;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


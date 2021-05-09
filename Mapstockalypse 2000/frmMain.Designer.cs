
namespace Mapstockalypse_2000
{
    partial class frmMain
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
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.scPanels = new System.Windows.Forms.SplitContainer();
            this.lstRaces = new System.Windows.Forms.ListBox();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.lstMods = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnInstall = new System.Windows.Forms.Button();
            this.fbdBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.llToxicRagers = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.gbPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).BeginInit();
            this.scPanels.Panel1.SuspendLayout();
            this.scPanels.Panel2.SuspendLayout();
            this.scPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPath
            // 
            this.gbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPath.Controls.Add(this.lblPath);
            this.gbPath.Controls.Add(this.btnBrowse);
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPath.Location = new System.Drawing.Point(12, 12);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(534, 42);
            this.gbPath.TabIndex = 0;
            this.gbPath.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(106, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Carmageddon 2 path";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(453, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(118, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(329, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "D:\\Carmageddon Installations\\Carmageddon 2";
            // 
            // scPanels
            // 
            this.scPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scPanels.Location = new System.Drawing.Point(12, 60);
            this.scPanels.Name = "scPanels";
            // 
            // scPanels.Panel1
            // 
            this.scPanels.Panel1.Controls.Add(this.lstRaces);
            // 
            // scPanels.Panel2
            // 
            this.scPanels.Panel2.Controls.Add(this.scRight);
            this.scPanels.Size = new System.Drawing.Size(534, 398);
            this.scPanels.SplitterDistance = 247;
            this.scPanels.TabIndex = 1;
            // 
            // lstRaces
            // 
            this.lstRaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRaces.FormattingEnabled = true;
            this.lstRaces.IntegralHeight = false;
            this.lstRaces.Location = new System.Drawing.Point(0, 0);
            this.lstRaces.Name = "lstRaces";
            this.lstRaces.Size = new System.Drawing.Size(247, 398);
            this.lstRaces.TabIndex = 0;
            this.lstRaces.SelectedIndexChanged += new System.EventHandler(this.lstRaces_SelectedIndexChanged);
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            this.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.lstMods);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.pnlButtons);
            this.scRight.Size = new System.Drawing.Size(283, 398);
            this.scRight.SplitterDistance = 299;
            this.scRight.TabIndex = 0;
            // 
            // lstMods
            // 
            this.lstMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMods.FormattingEnabled = true;
            this.lstMods.IntegralHeight = false;
            this.lstMods.Location = new System.Drawing.Point(0, 0);
            this.lstMods.Name = "lstMods";
            this.lstMods.Size = new System.Drawing.Size(283, 299);
            this.lstMods.TabIndex = 0;
            this.lstMods.SelectedIndexChanged += new System.EventHandler(this.lstMods_SelectedIndexChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.llToxicRagers);
            this.pnlButtons.Controls.Add(this.btnInstall);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(283, 95);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInstall.Location = new System.Drawing.Point(3, 3);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(275, 41);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "replace {race} with {mod}";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // fbdBrowse
            // 
            this.fbdBrowse.ShowNewFolderButton = false;
            // 
            // llToxicRagers
            // 
            this.llToxicRagers.Location = new System.Drawing.Point(3, 47);
            this.llToxicRagers.Name = "llToxicRagers";
            this.llToxicRagers.Size = new System.Drawing.Size(275, 41);
            this.llToxicRagers.TabIndex = 2;
            this.llToxicRagers.TabStop = true;
            this.llToxicRagers.Text = "Built with love by the one and only Toxic Ranger";
            this.llToxicRagers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llToxicRagers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llToxicRagers_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVersion.Location = new System.Drawing.Point(508, 453);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v1.0.0.0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 470);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.scPanels);
            this.Controls.Add(this.gbPath);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Mapstockalypse 2000";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.scPanels.Panel1.ResumeLayout(false);
            this.scPanels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPanels)).EndInit();
            this.scPanels.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.SplitContainer scPanels;
        private System.Windows.Forms.ListBox lstRaces;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.ListBox lstMods;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.LinkLabel llToxicRagers;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowse;
        private System.Windows.Forms.Label lblVersion;
    }
}


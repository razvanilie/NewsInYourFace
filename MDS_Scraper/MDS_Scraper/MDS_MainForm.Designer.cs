namespace MDS_Scraper
{
    partial class MDS_MainForm
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.btnExitProject = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelUiPath = new System.Windows.Forms.Label();
            this.btnFirstSite = new System.Windows.Forms.Button();
            this.btnSecondSite = new System.Windows.Forms.Button();
            this.btnThirdSite = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.timerEndApp = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.bottomPanel.Controls.Add(this.btnStart);
            this.bottomPanel.Controls.Add(this.labelUiPath);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 500);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(400, 100);
            this.bottomPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.topPanel.Controls.Add(this.lblHeader);
            this.topPanel.Controls.Add(this.btnExitProject);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(400, 75);
            this.topPanel.TabIndex = 1;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.txtDays);
            this.centerPanel.Controls.Add(this.lblDays);
            this.centerPanel.Controls.Add(this.btnThirdSite);
            this.centerPanel.Controls.Add(this.btnSecondSite);
            this.centerPanel.Controls.Add(this.btnFirstSite);
            this.centerPanel.Location = new System.Drawing.Point(0, 75);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(400, 425);
            this.centerPanel.TabIndex = 1;
            // 
            // btnExitProject
            // 
            this.btnExitProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitProject.BackColor = System.Drawing.Color.Transparent;
            this.btnExitProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitProject.FlatAppearance.BorderSize = 0;
            this.btnExitProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExitProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExitProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.btnExitProject.ForeColor = System.Drawing.Color.Red;
            this.btnExitProject.Location = new System.Drawing.Point(325, 0);
            this.btnExitProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitProject.Name = "btnExitProject";
            this.btnExitProject.Size = new System.Drawing.Size(75, 75);
            this.btnExitProject.TabIndex = 2;
            this.btnExitProject.TabStop = false;
            this.btnExitProject.Text = "X";
            this.btnExitProject.UseVisualStyleBackColor = false;
            this.btnExitProject.Click += new System.EventHandler(this.btnExitProject_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(111, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 42);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelUiPath
            // 
            this.labelUiPath.AutoSize = true;
            this.labelUiPath.BackColor = System.Drawing.Color.Transparent;
            this.labelUiPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUiPath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelUiPath.Location = new System.Drawing.Point(6, 34);
            this.labelUiPath.Name = "labelUiPath";
            this.labelUiPath.Size = new System.Drawing.Size(389, 42);
            this.labelUiPath.TabIndex = 25;
            this.labelUiPath.Text = "The robot was started.";
            this.labelUiPath.Visible = false;
            // 
            // btnFirstSite
            // 
            this.btnFirstSite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFirstSite.FlatAppearance.BorderSize = 0;
            this.btnFirstSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirstSite.Location = new System.Drawing.Point(80, 40);
            this.btnFirstSite.Name = "btnFirstSite";
            this.btnFirstSite.Size = new System.Drawing.Size(240, 50);
            this.btnFirstSite.TabIndex = 16;
            this.btnFirstSite.Text = "techcrunch.com";
            this.btnFirstSite.UseVisualStyleBackColor = false;
            this.btnFirstSite.Click += new System.EventHandler(this.btnFirstSite_Click);
            // 
            // btnSecondSite
            // 
            this.btnSecondSite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSecondSite.FlatAppearance.BorderSize = 0;
            this.btnSecondSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSecondSite.Location = new System.Drawing.Point(80, 130);
            this.btnSecondSite.Name = "btnSecondSite";
            this.btnSecondSite.Size = new System.Drawing.Size(240, 50);
            this.btnSecondSite.TabIndex = 17;
            this.btnSecondSite.Text = "cultivatedculture.com";
            this.btnSecondSite.UseVisualStyleBackColor = false;
            this.btnSecondSite.Click += new System.EventHandler(this.btnSecondSite_Click);
            // 
            // btnThirdSite
            // 
            this.btnThirdSite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThirdSite.FlatAppearance.BorderSize = 0;
            this.btnThirdSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThirdSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdSite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThirdSite.Location = new System.Drawing.Point(80, 220);
            this.btnThirdSite.Name = "btnThirdSite";
            this.btnThirdSite.Size = new System.Drawing.Size(240, 50);
            this.btnThirdSite.TabIndex = 18;
            this.btnThirdSite.Text = "uipath.com";
            this.btnThirdSite.UseVisualStyleBackColor = false;
            this.btnThirdSite.Click += new System.EventHandler(this.btnThirdSite_Click);
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(255, 331);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(65, 38);
            this.txtDays.TabIndex = 31;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(75, 340);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(163, 25);
            this.lblDays.TabIndex = 30;
            this.lblDays.Text = "Number of days";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(139, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(123, 29);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "MDS App";
            // 
            // timerEndApp
            // 
            this.timerEndApp.Interval = 10000;
            this.timerEndApp.Tick += new System.EventHandler(this.timerEndApp_Tick);
            // 
            // MDS_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MDS_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie MDS";
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnExitProject;
        private System.Windows.Forms.Label labelUiPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnThirdSite;
        private System.Windows.Forms.Button btnSecondSite;
        private System.Windows.Forms.Button btnFirstSite;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Timer timerEndApp;
    }
}


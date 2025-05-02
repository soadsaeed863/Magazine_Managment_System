namespace Magazine_Management_System
{
    partial class UserForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lumora = new System.Windows.Forms.Label();
            this.innerTopPanel = new System.Windows.Forms.Panel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.logoutbtn);
            this.topPanel.Controls.Add(this.searchPanel);
            this.topPanel.Controls.Add(this.lumora);
            this.topPanel.Controls.Add(this.innerTopPanel);
            this.topPanel.Controls.Add(this.profilePicture);
            this.topPanel.Controls.Add(this.homeIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1232, 64);
            this.topPanel.TabIndex = 0;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = global::Magazine_Management_System.Properties.Resources.logout;
            this.logoutbtn.Location = new System.Drawing.Point(12, 9);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(40, 46);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.TabStop = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Location = new System.Drawing.Point(79, 20);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(280, 30);
            this.searchPanel.TabIndex = 2;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.Image = global::Magazine_Management_System.Properties.Resources.search;
            this.searchIcon.Location = new System.Drawing.Point(5, 5);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(22, 22);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 2;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSearch.Location = new System.Drawing.Point(33, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // lumora
            // 
            this.lumora.AutoSize = true;
            this.lumora.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumora.Location = new System.Drawing.Point(970, 20);
            this.lumora.Name = "lumora";
            this.lumora.Size = new System.Drawing.Size(101, 35);
            this.lumora.TabIndex = 0;
            this.lumora.Text = "Lumora";
            // 
            // innerTopPanel
            // 
            this.innerTopPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerTopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.innerTopPanel.Location = new System.Drawing.Point(0, 63);
            this.innerTopPanel.Name = "innerTopPanel";
            this.innerTopPanel.Size = new System.Drawing.Size(1232, 1);
            this.innerTopPanel.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::Magazine_Management_System.Properties.Resources.profile_user;
            this.profilePicture.Location = new System.Drawing.Point(1164, 12);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(42, 43);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click_1);
            // 
            // homeIcon
            // 
            this.homeIcon.Image = global::Magazine_Management_System.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(1108, 12);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(39, 43);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click_1);
            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 64);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1232, 789);
            this.containerPanel.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1232, 853);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel innerTopPanel;
        private System.Windows.Forms.PictureBox logoutbtn;
        public System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label lumora;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox searchIcon;
    }
}
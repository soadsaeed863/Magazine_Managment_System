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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.lumora = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.innerTopPanel = new System.Windows.Forms.Panel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lumora);
            this.topPanel.Controls.Add(this.searchPanel);
            this.topPanel.Controls.Add(this.innerTopPanel);
            this.topPanel.Controls.Add(this.profilePicture);
            this.topPanel.Controls.Add(this.homeIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(924, 52);
            this.topPanel.TabIndex = 0;
            // 
            // lumora
            // 
            this.lumora.AutoSize = true;
            this.lumora.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumora.Location = new System.Drawing.Point(723, 15);
            this.lumora.Name = "lumora";
            this.lumora.Size = new System.Drawing.Size(86, 30);
            this.lumora.TabIndex = 2;
            this.lumora.Text = "Lumora";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Location = new System.Drawing.Point(53, 15);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(280, 30);
            this.searchPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSearch.Location = new System.Drawing.Point(33, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 18);
            this.txtSearch.TabIndex = 1;
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(5, 5);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(22, 22);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 0;
            this.searchIcon.TabStop = false;
            
            // 
            // innerTopPanel
            // 
            this.innerTopPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerTopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.innerTopPanel.Location = new System.Drawing.Point(0, 51);
            this.innerTopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.innerTopPanel.Name = "innerTopPanel";
            this.innerTopPanel.Size = new System.Drawing.Size(924, 1);
            this.innerTopPanel.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::Magazine_Management_System.Properties.Resources.profile_user;
            this.profilePicture.Location = new System.Drawing.Point(873, 10);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(32, 35);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.Image = global::Magazine_Management_System.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(831, 10);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(2);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(29, 35);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel.Location = new System.Drawing.Point(0, 52);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(924, 557);
            this.containerPanel.TabIndex = 1;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 609);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Shown += new System.EventHandler(this.UserForm_Shown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel innerTopPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label lumora;
    }
}
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoutbtn = new System.Windows.Forms.PictureBox();
            this.innerTopPanel = new System.Windows.Forms.Panel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.textBox1);
            this.topPanel.Controls.Add(this.logoutbtn);
            this.topPanel.Controls.Add(this.innerTopPanel);
            this.topPanel.Controls.Add(this.profilePicture);
            this.topPanel.Controls.Add(this.homeIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1232, 64);
            this.topPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 22);
            this.textBox1.TabIndex = 2;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Image = global::Magazine_Management_System.Properties.Resources.logout;
            this.logoutbtn.Location = new System.Drawing.Point(12, 9);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(73, 46);
            this.logoutbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.TabStop = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
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
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutbtn)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel containerPanel;
    }
}
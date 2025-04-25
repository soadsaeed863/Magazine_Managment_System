namespace Magazine_Managment_System
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topPanel = new Panel();
            homeIcon = new PictureBox();
            topInnerPanel = new Panel();
            profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            containerPanel = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(homeIcon);
            topPanel.Controls.Add(topInnerPanel);
            topPanel.Controls.Add(profilePicture);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1232, 64);
            topPanel.TabIndex = 0;
            // 
            // homeIcon
            // 
            homeIcon.Image = Properties.Resources.home;
            homeIcon.Location = new Point(1108, 12);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(39, 43);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 1;
            homeIcon.TabStop = false;
            // 
            // topInnerPanel
            // 
            topInnerPanel.BackColor = SystemColors.ActiveCaptionText;
            topInnerPanel.Dock = DockStyle.Bottom;
            topInnerPanel.Location = new Point(0, 63);
            topInnerPanel.Name = "topInnerPanel";
            topInnerPanel.Size = new Size(1232, 1);
            topInnerPanel.TabIndex = 1;
            // 
            // profilePicture
            // 
            profilePicture.Image = Properties.Resources.profile_user;
            profilePicture.ImageRotate = 0F;
            profilePicture.Location = new Point(1164, 12);
            profilePicture.Name = "profilePicture";
            profilePicture.ShadowDecoration.CustomizableEdges = customizableEdges1;
            profilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            profilePicture.Size = new Size(42, 43);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // containerPanel
            // 
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(0, 64);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1232, 789);
            containerPanel.TabIndex = 1;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 853);
            Controls.Add(containerPanel);
            Controls.Add(topPanel);
            Name = "UserForm";
            Text = "UserForm";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private Panel topPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Panel topInnerPanel;
        private PictureBox homeIcon;
        private Panel containerPanel;
    }
}
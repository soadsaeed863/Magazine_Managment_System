namespace Magazine_Management_System.UserControls
{
    partial class UC_UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pan = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.Notification = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 181);
            this.panel1.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UserName.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(580, 71);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(372, 32);
            this.UserName.TabIndex = 1;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(341, 20);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(179, 145);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pan
            // 
            this.pan.Controls.Add(this.Delete);
            this.pan.Controls.Add(this.Notification);
            this.pan.Controls.Add(this.button2);
            this.pan.Controls.Add(this.button1);
            this.pan.Location = new System.Drawing.Point(0, 181);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(1232, 45);
            this.pan.TabIndex = 1;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(364, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Favorite Article";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 226);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1232, 563);
            this.container.TabIndex = 2;
            // 
            // Notification
            // 
            this.Notification.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.Location = new System.Drawing.Point(682, 2);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(211, 45);
            this.Notification.TabIndex = 8;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(1018, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(211, 45);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete Account";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UC_UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.panel1);
            this.Name = "UC_UserProfile";
            this.Size = new System.Drawing.Size(1232, 789);
            this.Load += new System.EventHandler(this.UC_UserProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Notification;
        private System.Windows.Forms.Button Delete;
    }
}

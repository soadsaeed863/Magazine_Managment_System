namespace Magazine_Management_System.ProfileControls
{
    partial class Edit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.TextBox();
            this.ConfPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SecQu = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Picture URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secret Quesion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.confirm);
            this.panel1.Controls.Add(this.ConfPass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.URL);
            this.panel1.Controls.Add(this.PhoneNum);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.SecQu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(90, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 560);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(290, 33);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(190, 24);
            this.confirm.TabIndex = 12;
            // 
            // ConfPass
            // 
            this.ConfPass.AutoSize = true;
            this.ConfPass.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPass.Location = new System.Drawing.Point(24, 138);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.Size = new System.Drawing.Size(221, 32);
            this.ConfPass.TabIndex = 11;
            this.ConfPass.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(776, 147);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(190, 24);
            this.URL.TabIndex = 9;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNum.Location = new System.Drawing.Point(555, 258);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(190, 24);
            this.PhoneNum.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(290, 146);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(190, 24);
            this.Password.TabIndex = 7;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // SecQu
            // 
            this.SecQu.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecQu.Location = new System.Drawing.Point(776, 33);
            this.SecQu.Name = "SecQu";
            this.SecQu.Size = new System.Drawing.Size(190, 24);
            this.SecQu.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(1232, 563);
            this.Load += new System.EventHandler(this.Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SecQu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label ConfPass;
    }
}

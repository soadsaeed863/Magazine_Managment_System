namespace Magazine_Management_System.UserControls
{
    partial class UC_Section
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
            this.secNameLbl = new System.Windows.Forms.Label();
            this.secDetailsLbl = new System.Windows.Forms.Label();
            this.followbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NoarticlePanel = new System.Windows.Forms.Panel();
            this.NoarticleLbl = new System.Windows.Forms.Label();
            this.NoarticlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // secNameLbl
            // 
            this.secNameLbl.AutoSize = true;
            this.secNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secNameLbl.Location = new System.Drawing.Point(505, 45);
            this.secNameLbl.Name = "secNameLbl";
            this.secNameLbl.Size = new System.Drawing.Size(126, 38);
            this.secNameLbl.TabIndex = 0;
            this.secNameLbl.Text = "Fashon";
            // 
            // secDetailsLbl
            // 
            this.secDetailsLbl.AutoSize = true;
            this.secDetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secDetailsLbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.secDetailsLbl.Location = new System.Drawing.Point(419, 94);
            this.secDetailsLbl.Name = "secDetailsLbl";
            this.secDetailsLbl.Size = new System.Drawing.Size(297, 32);
            this.secDetailsLbl.TabIndex = 1;
            this.secDetailsLbl.Text = "12 Follower . 5 articles";
            // 
            // followbtn
            // 
            this.followbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followbtn.Location = new System.Drawing.Point(473, 142);
            this.followbtn.Name = "followbtn";
            this.followbtn.Size = new System.Drawing.Size(198, 41);
            this.followbtn.TabIndex = 2;
            this.followbtn.Text = "Follow";
            this.followbtn.UseVisualStyleBackColor = true;
            this.followbtn.Click += new System.EventHandler(this.followbtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latest Articles";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 227);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1232, 562);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // NoarticlePanel
            // 
            this.NoarticlePanel.Controls.Add(this.NoarticleLbl);
            this.NoarticlePanel.Location = new System.Drawing.Point(0, 189);
            this.NoarticlePanel.Name = "NoarticlePanel";
            this.NoarticlePanel.Size = new System.Drawing.Size(1232, 600);
            this.NoarticlePanel.TabIndex = 10;
            this.NoarticlePanel.Visible = false;
            // 
            // NoarticleLbl
            // 
            this.NoarticleLbl.AutoSize = true;
            this.NoarticleLbl.BackColor = System.Drawing.Color.IndianRed;
            this.NoarticleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoarticleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoarticleLbl.Location = new System.Drawing.Point(117, 143);
            this.NoarticleLbl.Name = "NoarticleLbl";
            this.NoarticleLbl.Size = new System.Drawing.Size(972, 69);
            this.NoarticleLbl.TabIndex = 0;
            this.NoarticleLbl.Text = "No articles added yet to this section";
            this.NoarticleLbl.Visible = false;
            // 
            // UC_Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoarticlePanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.followbtn);
            this.Controls.Add(this.secDetailsLbl);
            this.Controls.Add(this.secNameLbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Section";
            this.Size = new System.Drawing.Size(1232, 789);
            this.Load += new System.EventHandler(this.UC_Section_Load);
            this.NoarticlePanel.ResumeLayout(false);
            this.NoarticlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secNameLbl;
        private System.Windows.Forms.Label secDetailsLbl;
        private System.Windows.Forms.Button followbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel NoarticlePanel;
        private System.Windows.Forms.Label NoarticleLbl;
    }
}

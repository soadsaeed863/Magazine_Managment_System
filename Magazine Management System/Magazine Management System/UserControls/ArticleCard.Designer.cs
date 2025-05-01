namespace Magazine_Management_System.UserControls
{
    partial class ArticleCard
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentsLbl = new System.Windows.Forms.Label();
            this.reactsLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.commentIcon = new System.Windows.Forms.PictureBox();
            this.reactIcon = new System.Windows.Forms.PictureBox();
            this.clockIcon = new System.Windows.Forms.PictureBox();
            this.articleImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(4, 143);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(361, 29);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Top 10 Summer Fashion Trends and the power of trinding things and how to deal wit" +
    "h everything";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentsLbl);
            this.panel1.Controls.Add(this.reactsLbl);
            this.panel1.Controls.Add(this.dateLbl);
            this.panel1.Controls.Add(this.commentIcon);
            this.panel1.Controls.Add(this.reactIcon);
            this.panel1.Controls.Add(this.clockIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 45);
            this.panel1.TabIndex = 2;
            // 
            // commentsLbl
            // 
            this.commentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLbl.Location = new System.Drawing.Point(224, 10);
            this.commentsLbl.Name = "commentsLbl";
            this.commentsLbl.Size = new System.Drawing.Size(25, 17);
            this.commentsLbl.TabIndex = 3;
            this.commentsLbl.Text = "3";
            // 
            // reactsLbl
            // 
            this.reactsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactsLbl.Location = new System.Drawing.Point(320, 10);
            this.reactsLbl.Name = "reactsLbl";
            this.reactsLbl.Size = new System.Drawing.Size(22, 17);
            this.reactsLbl.TabIndex = 4;
            this.reactsLbl.Text = "5";
            // 
            // dateLbl
            // 
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(55, 10);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(10);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(100, 17);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "20-APR-15";
            // 
            // commentIcon
            // 
            this.commentIcon.Image = global::Magazine_Management_System.Properties.Resources.chat;
            this.commentIcon.Location = new System.Drawing.Point(168, 3);
            this.commentIcon.Name = "commentIcon";
            this.commentIcon.Size = new System.Drawing.Size(50, 39);
            this.commentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commentIcon.TabIndex = 5;
            this.commentIcon.TabStop = false;
            // 
            // reactIcon
            // 
            this.reactIcon.Image = global::Magazine_Management_System.Properties.Resources.clap;
            this.reactIcon.Location = new System.Drawing.Point(255, 3);
            this.reactIcon.Name = "reactIcon";
            this.reactIcon.Size = new System.Drawing.Size(59, 39);
            this.reactIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reactIcon.TabIndex = 4;
            this.reactIcon.TabStop = false;
            // 
            // clockIcon
            // 
            this.clockIcon.Image = global::Magazine_Management_System.Properties.Resources.clock;
            this.clockIcon.Location = new System.Drawing.Point(3, 3);
            this.clockIcon.Name = "clockIcon";
            this.clockIcon.Size = new System.Drawing.Size(49, 39);
            this.clockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clockIcon.TabIndex = 3;
            this.clockIcon.TabStop = false;
            // 
            // articleImg
            // 
            this.articleImg.Image = global::Magazine_Management_System.Properties.Resources.article2;
            this.articleImg.Location = new System.Drawing.Point(0, 0);
            this.articleImg.Name = "articleImg";
            this.articleImg.Size = new System.Drawing.Size(367, 136);
            this.articleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.articleImg.TabIndex = 0;
            this.articleImg.TabStop = false;
            // 
            // ArticleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.articleImg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(30, 10, 5, 30);
            this.Name = "ArticleCard";
            this.Size = new System.Drawing.Size(366, 250);
            this.Load += new System.EventHandler(this.ArticleCard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reactIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox articleImg;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label commentsLbl;
        private System.Windows.Forms.Label reactsLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.PictureBox commentIcon;
        private System.Windows.Forms.PictureBox reactIcon;
        private System.Windows.Forms.PictureBox clockIcon;
    }
}

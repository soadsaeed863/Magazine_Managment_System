namespace Magazine_Management_System.UserControls
{
    partial class ArticleDetails
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
            this.Title = new System.Windows.Forms.Label();
            this.reactlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.commentsCount = new System.Windows.Forms.Label();
            this.publisherName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.commentFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Button();
            this.contentLbl = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.artImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(73, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(95, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // reactlbl
            // 
            this.reactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactlbl.Location = new System.Drawing.Point(130, 450);
            this.reactlbl.Name = "reactlbl";
            this.reactlbl.Size = new System.Drawing.Size(44, 21);
            this.reactlbl.TabIndex = 4;
            this.reactlbl.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 502);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 10;
            // 
            // commentsCount
            // 
            this.commentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsCount.Location = new System.Drawing.Point(220, 450);
            this.commentsCount.Name = "commentsCount";
            this.commentsCount.Size = new System.Drawing.Size(44, 21);
            this.commentsCount.TabIndex = 11;
            this.commentsCount.Text = "0";
            // 
            // publisherName
            // 
            this.publisherName.AutoSize = true;
            this.publisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherName.Location = new System.Drawing.Point(994, 193);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(178, 29);
            this.publisherName.TabIndex = 13;
            this.publisherName.Text = "publisherName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(943, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "By:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(929, 225);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(118, 29);
            this.Date.TabIndex = 15;
            this.Date.Text = "10/9/2025";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Responses";
            // 
            // commentFlow
            // 
            this.commentFlow.AutoScroll = true;
            this.commentFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentFlow.Location = new System.Drawing.Point(68, 605);
            this.commentFlow.Name = "commentFlow";
            this.commentFlow.Size = new System.Drawing.Size(1139, 159);
            this.commentFlow.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Write a response";
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment.Location = new System.Drawing.Point(555, 530);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(160, 40);
            this.comment.TabIndex = 19;
            this.comment.Text = "comment";
            this.comment.UseVisualStyleBackColor = true;
            this.comment.Click += new System.EventHandler(this.comment_Click);
            // 
            // contentLbl
            // 
            this.contentLbl.AutoSize = true;
            this.contentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLbl.Location = new System.Drawing.Point(68, 276);
            this.contentLbl.MaximumSize = new System.Drawing.Size(1139, 0);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(92, 32);
            this.contentLbl.TabIndex = 20;
            this.contentLbl.Text = "label1";
            // 
            // save
            // 
            this.save.Image = global::Magazine_Management_System.Properties.Resources.unsaved;
            this.save.Location = new System.Drawing.Point(1162, 436);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(38, 50);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save.TabIndex = 12;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Magazine_Management_System.Properties.Resources.chat;
            this.pictureBox3.Location = new System.Drawing.Point(160, 436);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Magazine_Management_System.Properties.Resources.clap;
            this.pictureBox2.Location = new System.Drawing.Point(70, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // artImg
            // 
            this.artImg.Image = global::Magazine_Management_System.Properties.Resources.article2;
            this.artImg.Location = new System.Drawing.Point(68, 80);
            this.artImg.Name = "artImg";
            this.artImg.Size = new System.Drawing.Size(726, 174);
            this.artImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.artImg.TabIndex = 1;
            this.artImg.TabStop = false;
            // 
            // ArticleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentLbl);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentFlow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publisherName);
            this.Controls.Add(this.save);
            this.Controls.Add(this.commentsCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reactlbl);
            this.Controls.Add(this.artImg);
            this.Controls.Add(this.Title);
            this.Name = "ArticleDetails";
            this.Size = new System.Drawing.Size(1232, 789);
            this.Load += new System.EventHandler(this.UC_ArticleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox artImg;
        private System.Windows.Forms.Label reactlbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label commentsCount;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Label publisherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel commentFlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button comment;
        private System.Windows.Forms.Label contentLbl;
    }
}

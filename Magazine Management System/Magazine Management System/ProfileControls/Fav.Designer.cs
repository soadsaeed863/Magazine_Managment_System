namespace Magazine_Management_System.ProfileControls
{
    partial class Fav
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
            this.continer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // continer
            // 
            this.continer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.continer.Location = new System.Drawing.Point(73, 4);
            this.continer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continer.Name = "continer";
            this.continer.Size = new System.Drawing.Size(1050, 789);
            this.continer.TabIndex = 0;
            this.continer.Paint += new System.Windows.Forms.PaintEventHandler(this.continer_Paint);
            // 
            // Fav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.continer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fav";
            this.Size = new System.Drawing.Size(1211, 789);
            this.Load += new System.EventHandler(this.Fav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel continer;
    }
}

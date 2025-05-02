namespace Magazine_Management_System.UserControls
{
    partial class Home
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
            this.sections = new System.Windows.Forms.FlowLayoutPanel();
            this.articles = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // sections
            // 
            this.sections.Location = new System.Drawing.Point(154, 29);
            this.sections.Name = "sections";
            this.sections.Size = new System.Drawing.Size(876, 72);
            this.sections.TabIndex = 0;
            // 
            // articles
            // 
            this.articles.Location = new System.Drawing.Point(0, 163);
            this.articles.Name = "articles";
            this.articles.Size = new System.Drawing.Size(1232, 552);
            this.articles.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.articles);
            this.Controls.Add(this.sections);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1232, 789);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sections;
        private System.Windows.Forms.FlowLayoutPanel articles;
    }
}

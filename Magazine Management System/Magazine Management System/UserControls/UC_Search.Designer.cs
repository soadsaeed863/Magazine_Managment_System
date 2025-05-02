namespace Magazine_Management_System.UserControls
{
    partial class UC_Search
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
            this.searchResult = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // searchResult
            // 
            this.searchResult.AutoScroll = true;
            this.searchResult.Location = new System.Drawing.Point(0, 20);
            this.searchResult.Margin = new System.Windows.Forms.Padding(0);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(1232, 819);
            this.searchResult.TabIndex = 0;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchResult);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(1232, 789);
            this.Load += new System.EventHandler(this.UC_Search_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel searchResult;
    }
}

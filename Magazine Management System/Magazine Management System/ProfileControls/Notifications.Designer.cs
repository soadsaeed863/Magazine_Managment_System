namespace Magazine_Management_System.ProfileControls
{
    partial class Notifications
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
            this.container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(242, 3);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(805, 563);
            this.container.TabIndex = 0;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "Notifications";
            this.Size = new System.Drawing.Size(1232, 563);
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
    }
}

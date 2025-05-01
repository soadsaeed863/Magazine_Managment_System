namespace Magazine_Management_System.UserControls
{
    partial class UC_Home
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
            this.sectionPanel = new System.Windows.Forms.Panel();
            this.section_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.sectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionPanel
            // 
            this.sectionPanel.Controls.Add(this.section_flow);
            this.sectionPanel.Location = new System.Drawing.Point(205, 4);
            this.sectionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sectionPanel.Name = "sectionPanel";
            this.sectionPanel.Size = new System.Drawing.Size(924, 60);
            this.sectionPanel.TabIndex = 0;
            // 
            // section_flow
            // 
            this.section_flow.AutoScroll = true;
            this.section_flow.Location = new System.Drawing.Point(0, 0);
            this.section_flow.Margin = new System.Windows.Forms.Padding(10);
            this.section_flow.Name = "section_flow";
            this.section_flow.Padding = new System.Windows.Forms.Padding(10);
            this.section_flow.Size = new System.Drawing.Size(924, 60);
            this.section_flow.TabIndex = 5;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sectionPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1643, 1032);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.sectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sectionPanel;
        private System.Windows.Forms.FlowLayoutPanel section_flow;
    }
}

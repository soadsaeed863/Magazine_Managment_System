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
            this.label3 = new System.Windows.Forms.Label();
            this.latestArticlesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionPanel
            // 
            this.sectionPanel.Controls.Add(this.section_flow);
            this.sectionPanel.Location = new System.Drawing.Point(183, 59);
            this.sectionPanel.Name = "sectionPanel";
            this.sectionPanel.Size = new System.Drawing.Size(739, 69);
            this.sectionPanel.TabIndex = 0;
            // 
            // section_flow
            // 
            this.section_flow.AutoScroll = true;
            this.section_flow.Location = new System.Drawing.Point(0, 0);
            this.section_flow.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.section_flow.Name = "section_flow";
            this.section_flow.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.section_flow.Size = new System.Drawing.Size(739, 69);
            this.section_flow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Latest Articles";
            // 
            // latestArticlesPanel
            // 
            this.latestArticlesPanel.AutoScroll = true;
            this.latestArticlesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.latestArticlesPanel.Location = new System.Drawing.Point(0, 234);
            this.latestArticlesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.latestArticlesPanel.Name = "latestArticlesPanel";
            this.latestArticlesPanel.Size = new System.Drawing.Size(1232, 605);
            this.latestArticlesPanel.TabIndex = 13;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.latestArticlesPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sectionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1232, 789);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.sectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sectionPanel;
        private System.Windows.Forms.FlowLayoutPanel section_flow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel latestArticlesPanel;
    }
}
namespace WaitlistApplication
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainForm_MenuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.MainForm_MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_View = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_InsidePanel = new System.Windows.Forms.Panel();
            this.MainForm_ElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.MainForm_OuterPanel = new System.Windows.Forms.Panel();
            this.MainForm_MenuStrip_Bottom = new System.Windows.Forms.MenuStrip();
            this.MainForm_MenuStrip_Bottom_NewRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Bottom_PastRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Bottom_Analytics = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_MenuStrip_Top.SuspendLayout();
            this.MainForm_InsidePanel.SuspendLayout();
            this.MainForm_OuterPanel.SuspendLayout();
            this.MainForm_MenuStrip_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_MenuStrip_Top
            // 
            this.MainForm_MenuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainForm_MenuStrip_File,
            this.MainForm_MenuStrip_Edit,
            this.MainForm_MenuStrip_View,
            this.MainForm_MenuStrip_Help,
            this.MainForm_MenuStrip_Admin});
            this.MainForm_MenuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.MainForm_MenuStrip_Top.Name = "MainForm_MenuStrip_Top";
            this.MainForm_MenuStrip_Top.Size = new System.Drawing.Size(1184, 24);
            this.MainForm_MenuStrip_Top.TabIndex = 0;
            // 
            // MainForm_MenuStrip_File
            // 
            this.MainForm_MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem2,
            this.testToolStripMenuItem3});
            this.MainForm_MenuStrip_File.Name = "MainForm_MenuStrip_File";
            this.MainForm_MenuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MainForm_MenuStrip_File.Text = "File";
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.testToolStripMenuItem2.Text = "Test";
            // 
            // testToolStripMenuItem3
            // 
            this.testToolStripMenuItem3.Name = "testToolStripMenuItem3";
            this.testToolStripMenuItem3.Size = new System.Drawing.Size(94, 22);
            this.testToolStripMenuItem3.Text = "Test";
            // 
            // MainForm_MenuStrip_Edit
            // 
            this.MainForm_MenuStrip_Edit.Name = "MainForm_MenuStrip_Edit";
            this.MainForm_MenuStrip_Edit.Size = new System.Drawing.Size(39, 20);
            this.MainForm_MenuStrip_Edit.Text = "Edit";
            // 
            // MainForm_MenuStrip_View
            // 
            this.MainForm_MenuStrip_View.Name = "MainForm_MenuStrip_View";
            this.MainForm_MenuStrip_View.Size = new System.Drawing.Size(44, 20);
            this.MainForm_MenuStrip_View.Text = "View";
            // 
            // MainForm_MenuStrip_Help
            // 
            this.MainForm_MenuStrip_Help.Name = "MainForm_MenuStrip_Help";
            this.MainForm_MenuStrip_Help.Size = new System.Drawing.Size(44, 20);
            this.MainForm_MenuStrip_Help.Text = "Help";
            // 
            // MainForm_MenuStrip_Admin
            // 
            this.MainForm_MenuStrip_Admin.Name = "MainForm_MenuStrip_Admin";
            this.MainForm_MenuStrip_Admin.Size = new System.Drawing.Size(55, 20);
            this.MainForm_MenuStrip_Admin.Text = "Admin";
            // 
            // MainForm_InsidePanel
            // 
            this.MainForm_InsidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_InsidePanel.Controls.Add(this.MainForm_ElementHost);
            this.MainForm_InsidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_InsidePanel.Location = new System.Drawing.Point(3, 3);
            this.MainForm_InsidePanel.Name = "MainForm_InsidePanel";
            this.MainForm_InsidePanel.Padding = new System.Windows.Forms.Padding(3);
            this.MainForm_InsidePanel.Size = new System.Drawing.Size(1178, 708);
            this.MainForm_InsidePanel.TabIndex = 1;
            // 
            // MainForm_ElementHost
            // 
            this.MainForm_ElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_ElementHost.Location = new System.Drawing.Point(3, 3);
            this.MainForm_ElementHost.Name = "MainForm_ElementHost";
            this.MainForm_ElementHost.Size = new System.Drawing.Size(1168, 698);
            this.MainForm_ElementHost.TabIndex = 0;
            this.MainForm_ElementHost.Child = null;
            // 
            // MainForm_OuterPanel
            // 
            this.MainForm_OuterPanel.Controls.Add(this.MainForm_InsidePanel);
            this.MainForm_OuterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_OuterPanel.Location = new System.Drawing.Point(0, 24);
            this.MainForm_OuterPanel.Name = "MainForm_OuterPanel";
            this.MainForm_OuterPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MainForm_OuterPanel.Size = new System.Drawing.Size(1184, 714);
            this.MainForm_OuterPanel.TabIndex = 2;
            // 
            // MainForm_MenuStrip_Bottom
            // 
            this.MainForm_MenuStrip_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainForm_MenuStrip_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainForm_MenuStrip_Bottom_NewRequest,
            this.MainForm_MenuStrip_Bottom_PastRequests,
            this.MainForm_MenuStrip_Bottom_Analytics});
            this.MainForm_MenuStrip_Bottom.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainForm_MenuStrip_Bottom.Location = new System.Drawing.Point(0, 738);
            this.MainForm_MenuStrip_Bottom.Name = "MainForm_MenuStrip_Bottom";
            this.MainForm_MenuStrip_Bottom.Size = new System.Drawing.Size(1184, 23);
            this.MainForm_MenuStrip_Bottom.TabIndex = 3;
            // 
            // MainForm_MenuStrip_Bottom_NewRequest
            // 
            this.MainForm_MenuStrip_Bottom_NewRequest.Name = "MainForm_MenuStrip_Bottom_NewRequest";
            this.MainForm_MenuStrip_Bottom_NewRequest.Size = new System.Drawing.Size(88, 19);
            this.MainForm_MenuStrip_Bottom_NewRequest.Text = "New Request";
            this.MainForm_MenuStrip_Bottom_NewRequest.Click += new System.EventHandler(this.MainForm_MenuStrip_Bottom_NewRequest_Click);
            // 
            // MainForm_MenuStrip_Bottom_PastRequests
            // 
            this.MainForm_MenuStrip_Bottom_PastRequests.Name = "MainForm_MenuStrip_Bottom_PastRequests";
            this.MainForm_MenuStrip_Bottom_PastRequests.Size = new System.Drawing.Size(91, 19);
            this.MainForm_MenuStrip_Bottom_PastRequests.Text = "Past Requests";
            // 
            // MainForm_MenuStrip_Bottom_Analytics
            // 
            this.MainForm_MenuStrip_Bottom_Analytics.Name = "MainForm_MenuStrip_Bottom_Analytics";
            this.MainForm_MenuStrip_Bottom_Analytics.Size = new System.Drawing.Size(67, 19);
            this.MainForm_MenuStrip_Bottom_Analytics.Text = "Analytics";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MainForm_OuterPanel);
            this.Controls.Add(this.MainForm_MenuStrip_Top);
            this.Controls.Add(this.MainForm_MenuStrip_Bottom);
            this.MainMenuStrip = this.MainForm_MenuStrip_Top;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manitowoc Tool and Manufacturing | Waitlist Application | Version: 0.0.0.1";
            this.MainForm_MenuStrip_Top.ResumeLayout(false);
            this.MainForm_MenuStrip_Top.PerformLayout();
            this.MainForm_InsidePanel.ResumeLayout(false);
            this.MainForm_OuterPanel.ResumeLayout(false);
            this.MainForm_MenuStrip_Bottom.ResumeLayout(false);
            this.MainForm_MenuStrip_Bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainForm_MenuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Edit;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_View;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Admin;
        private System.Windows.Forms.Panel MainForm_InsidePanel;
        private System.Windows.Forms.Integration.ElementHost MainForm_ElementHost;
        private System.Windows.Forms.Panel MainForm_OuterPanel;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem3;
        private System.Windows.Forms.MenuStrip MainForm_MenuStrip_Bottom;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Bottom_NewRequest;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Bottom_PastRequests;
        private System.Windows.Forms.ToolStripMenuItem MainForm_MenuStrip_Bottom_Analytics;
    }
}


namespace Monitor1
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addMonitoredDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMonitorView = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.debugLoadSampleConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDevicesToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.saveConfigurationasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem2,
            this.debugLoadSampleConfigToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMonitoredDeviceToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // addMonitoredDeviceToolStripMenuItem
            // 
            this.addMonitoredDeviceToolStripMenuItem.Name = "addMonitoredDeviceToolStripMenuItem";
            this.addMonitoredDeviceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addMonitoredDeviceToolStripMenuItem.Text = "&Add monitored device...";
            this.addMonitoredDeviceToolStripMenuItem.Click += new System.EventHandler(this.addMonitoredDeviceToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNowToolStripMenuItem1});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // refreshNowToolStripMenuItem1
            // 
            this.refreshNowToolStripMenuItem1.Name = "refreshNowToolStripMenuItem1";
            this.refreshNowToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.refreshNowToolStripMenuItem1.Text = "&Refresh now";
            this.refreshNowToolStripMenuItem1.Click += new System.EventHandler(this.refreshNowToolStripMenuItem_Click);
            // 
            // panelMonitorView
            // 
            this.panelMonitorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitorView.Location = new System.Drawing.Point(0, 24);
            this.panelMonitorView.Name = "panelMonitorView";
            this.panelMonitorView.Size = new System.Drawing.Size(918, 478);
            this.panelMonitorView.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNowToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // refreshNowToolStripMenuItem
            // 
            this.refreshNowToolStripMenuItem.Name = "refreshNowToolStripMenuItem";
            this.refreshNowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.refreshNowToolStripMenuItem.Text = "&Refresh now";
            this.refreshNowToolStripMenuItem.Click += new System.EventHandler(this.refreshNowToolStripMenuItem_Click);
            // 
            // loadDevicesToolStripMenuItem
            // 
            this.loadDevicesToolStripMenuItem.Name = "loadDevicesToolStripMenuItem";
            this.loadDevicesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loadDevicesToolStripMenuItem.Text = "&Load configuration...";
            this.loadDevicesToolStripMenuItem.Click += new System.EventHandler(this.loadDevicesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveConfigurationToolStripMenuItem.Text = "&Save configuration";
            // 
            // saveConfigurationasToolStripMenuItem
            // 
            this.saveConfigurationasToolStripMenuItem.Name = "saveConfigurationasToolStripMenuItem";
            this.saveConfigurationasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveConfigurationasToolStripMenuItem.Text = "Save configuration &as...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 6);
            // 
            // debugLoadSampleConfigToolStripMenuItem
            // 
            this.debugLoadSampleConfigToolStripMenuItem.Name = "debugLoadSampleConfigToolStripMenuItem";
            this.debugLoadSampleConfigToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.debugLoadSampleConfigToolStripMenuItem.Text = "(Debug) Load sample config";
            this.debugLoadSampleConfigToolStripMenuItem.Click += new System.EventHandler(this.debugLoadSampleConfigToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 524);
            this.Controls.Add(this.panelMonitorView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelMonitorView;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshNowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMonitoredDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem debugLoadSampleConfigToolStripMenuItem;
    }
}


namespace USBLoggerApp
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 25);
            this.lblTitle.Text = "USB Activity Logger";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.groupBox1.Controls.Add(this.lblEvent);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.Text = "Last Event";

            this.lblEvent.Location = new System.Drawing.Point(10, 20);
            this.lblEvent.Size = new System.Drawing.Size(230, 20);
            this.lblEvent.Text = "Event: ---";

            this.lblTime.Location = new System.Drawing.Point(10, 45);
            this.lblTime.Size = new System.Drawing.Size(230, 20);
            this.lblTime.Text = "Time: ---";

            this.lblCount.Location = new System.Drawing.Point(10, 70);
            this.lblCount.Size = new System.Drawing.Size(230, 20);
            this.lblCount.Text = "Total Events: 0";

            this.btnOpenLog.Location = new System.Drawing.Point(100, 200);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(120, 30);
            this.btnOpenLog.Text = "Open Log File";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);

            this.fileToolStripMenuItem.DropDownItems.Add(this.exitToolStripMenuItem);
            this.fileToolStripMenuItem.Text = "File";

            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            this.ClientSize = new System.Drawing.Size(320, 260);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "USB Activity Logger";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace EmbeddedBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonGithub = new System.Windows.Forms.ToolStripButton();
            this.ButtonGoogle = new System.Windows.Forms.ToolStripButton();
            this.ButtonLinkedIn = new System.Windows.Forms.ToolStripButton();
            this.ButtonFacebook = new System.Windows.Forms.ToolStripButton();
            this.geckoWebBrowser = new Gecko.GeckoWebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonGoogle,
            this.ButtonFacebook,
            this.ButtonLinkedIn,
            this.ButtonGithub});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonGithub
            // 
            this.ButtonGithub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonGithub.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGithub.Image")));
            this.ButtonGithub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGithub.Name = "ButtonGithub";
            this.ButtonGithub.Size = new System.Drawing.Size(36, 36);
            this.ButtonGithub.Text = "toolStripButton1";
            this.ButtonGithub.Click += new System.EventHandler(this.ButtonGithub_Click);
            // 
            // ButtonGoogle
            // 
            this.ButtonGoogle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonGoogle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGoogle.Image")));
            this.ButtonGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGoogle.Name = "ButtonGoogle";
            this.ButtonGoogle.Size = new System.Drawing.Size(36, 36);
            this.ButtonGoogle.Text = "toolStripButton2";
            this.ButtonGoogle.Click += new System.EventHandler(this.ButtonGoogle_Click);
            // 
            // ButtonLinkedIn
            // 
            this.ButtonLinkedIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLinkedIn.Image")));
            this.ButtonLinkedIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonLinkedIn.Name = "ButtonLinkedIn";
            this.ButtonLinkedIn.Size = new System.Drawing.Size(36, 36);
            this.ButtonLinkedIn.Text = "toolStripButton3";
            this.ButtonLinkedIn.Click += new System.EventHandler(this.ButtonLinkedIn_Click);
            // 
            // ButtonFacebook
            // 
            this.ButtonFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonFacebook.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFacebook.Image")));
            this.ButtonFacebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonFacebook.Name = "ButtonFacebook";
            this.ButtonFacebook.Size = new System.Drawing.Size(36, 36);
            this.ButtonFacebook.Text = "toolStripButton4";
            this.ButtonFacebook.Click += new System.EventHandler(this.ButtonFacebook_Click);
            // 
            // geckoWebBrowser
            // 
            this.geckoWebBrowser.ConsoleMessageEventReceivesConsoleLogCalls = true;
            this.geckoWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser.Location = new System.Drawing.Point(0, 39);
            this.geckoWebBrowser.Name = "geckoWebBrowser";
            this.geckoWebBrowser.Size = new System.Drawing.Size(662, 414);
            this.geckoWebBrowser.TabIndex = 1;
            this.geckoWebBrowser.UseHttpActivityObserver = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.geckoWebBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Embedded Firefox Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonGoogle;
        private System.Windows.Forms.ToolStripButton ButtonFacebook;
        private System.Windows.Forms.ToolStripButton ButtonLinkedIn;
        private System.Windows.Forms.ToolStripButton ButtonGithub;
        private Gecko.GeckoWebBrowser geckoWebBrowser;
    }
}


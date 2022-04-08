namespace GarbageMan
{
    partial class formGMMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGMMain));
            this.iconGMTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsGMTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openRecycleBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyRecycleBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silentlyWithoutConfirmationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGMTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconGMTray
            // 
            this.iconGMTray.ContextMenuStrip = this.cmsGMTrayMenu;
            this.iconGMTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconGMTray.Icon")));
            this.iconGMTray.Text = "GarbageMan";
            this.iconGMTray.Visible = true;
            this.iconGMTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.iconGMTray_MouseDoubleClick);
            // 
            // cmsGMTrayMenu
            // 
            this.cmsGMTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRecycleBinToolStripMenuItem,
            this.emptyRecycleBinToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.cmsGMTrayMenu.Name = "cmsGMTrayMenu";
            this.cmsGMTrayMenu.Size = new System.Drawing.Size(172, 70);
            // 
            // openRecycleBinToolStripMenuItem
            // 
            this.openRecycleBinToolStripMenuItem.Name = "openRecycleBinToolStripMenuItem";
            this.openRecycleBinToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openRecycleBinToolStripMenuItem.Text = "Open Recycle Bin";
            this.openRecycleBinToolStripMenuItem.Click += new System.EventHandler(this.openRecycleBinToolStripMenuItem_Click);
            // 
            // emptyRecycleBinToolStripMenuItem
            // 
            this.emptyRecycleBinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silentlyWithoutConfirmationToolStripMenuItem});
            this.emptyRecycleBinToolStripMenuItem.Name = "emptyRecycleBinToolStripMenuItem";
            this.emptyRecycleBinToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.emptyRecycleBinToolStripMenuItem.Text = "Empty Recycle Bin";
            this.emptyRecycleBinToolStripMenuItem.Click += new System.EventHandler(this.emptyRecycleBinToolStripMenuItem_Click);
            // 
            // silentlyWithoutConfirmationToolStripMenuItem
            // 
            this.silentlyWithoutConfirmationToolStripMenuItem.Name = "silentlyWithoutConfirmationToolStripMenuItem";
            this.silentlyWithoutConfirmationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.silentlyWithoutConfirmationToolStripMenuItem.Text = "Silently without confirmation";
            this.silentlyWithoutConfirmationToolStripMenuItem.Click += new System.EventHandler(this.silentlyWithoutConfirmationToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeProgramToolStripMenuItem.Text = "Close program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // formGMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "formGMMain";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.cmsGMTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon iconGMTray;
        private System.Windows.Forms.ContextMenuStrip cmsGMTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem openRecycleBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyRecycleBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silentlyWithoutConfirmationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
    }
}

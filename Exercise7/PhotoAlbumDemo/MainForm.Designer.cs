namespace PhotoAlbumDemo
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(782, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.loadAlbum,
            this.saveMenu,
            this.exitMenu});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 24);
            this.menuFile.Text = "File";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.ShortcutKeyDisplayString = "";
            this.menuLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuLoad.Size = new System.Drawing.Size(217, 26);
            this.menuLoad.Text = "&Load Image";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // loadAlbum
            // 
            this.loadAlbum.Name = "loadAlbum";
            this.loadAlbum.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.loadAlbum.Size = new System.Drawing.Size(217, 26);
            this.loadAlbum.Text = "&Load Album";
            this.loadAlbum.Click += new System.EventHandler(this.loadAlbum_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenu.Size = new System.Drawing.Size(217, 26);
            this.saveMenu.Text = "&Save Album";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenu.Size = new System.Drawing.Size(217, 26);
            this.exitMenu.Text = "&Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.menuAlbum});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(53, 24);
            this.menuView.Text = "View";
            this.menuView.Click += new System.EventHandler(this.menuView_Click);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStretch,
            this.menuActual,
            this.menuCenter});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(216, 26);
            this.menuImage.Text = "Image";
            // 
            // menuStretch
            // 
            this.menuStretch.Name = "menuStretch";
            this.menuStretch.Size = new System.Drawing.Size(216, 26);
            this.menuStretch.Text = "&Stretch to Fit";
            this.menuStretch.Click += new System.EventHandler(this.menuView_Click);
            // 
            // menuActual
            // 
            this.menuActual.Name = "menuActual";
            this.menuActual.Size = new System.Drawing.Size(216, 26);
            this.menuActual.Text = "&Actual Size";
            this.menuActual.Click += new System.EventHandler(this.menuView_Click);
            // 
            // menuCenter
            // 
            this.menuCenter.Name = "menuCenter";
            this.menuCenter.Size = new System.Drawing.Size(216, 26);
            this.menuCenter.Text = "&Center Image";
            this.menuCenter.Click += new System.EventHandler(this.menuView_Click);
            // 
            // menuAlbum
            // 
            this.menuAlbum.Name = "menuAlbum";
            this.menuAlbum.Size = new System.Drawing.Size(216, 26);
            this.menuAlbum.Text = "Photo Album";
            this.menuAlbum.Click += new System.EventHandler(this.menuAlbum_Click);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox.Location = new System.Drawing.Point(0, 28);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(782, 525);
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(304, 471);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 34);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // previous
            // 
            this.previous.Dock = System.Windows.Forms.DockStyle.Left;
            this.previous.Location = new System.Drawing.Point(0, 28);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 525);
            this.previous.TabIndex = 3;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Dock = System.Windows.Forms.DockStyle.Right;
            this.next.Location = new System.Drawing.Point(707, 28);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 525);
            this.next.TabIndex = 4;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFileName,
            this.statusImageSize});
            this.statusBar.Location = new System.Drawing.Point(75, 528);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(632, 25);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusFileName
            // 
            this.statusFileName.Name = "statusFileName";
            this.statusFileName.Size = new System.Drawing.Size(151, 20);
            this.statusFileName.Text = "toolStripStatusLabel1";
            // 
            // statusImageSize
            // 
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(151, 20);
            this.statusImageSize.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainForm";
            this.Text = "Photo Album";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripMenuItem loadAlbum;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuStretch;
        private System.Windows.Forms.ToolStripMenuItem menuActual;
        private System.Windows.Forms.ToolStripMenuItem menuCenter;
        private System.Windows.Forms.ToolStripMenuItem menuAlbum;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusFileName;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
    }
}


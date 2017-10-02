namespace gamma_viewer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.status = new System.Windows.Forms.StatusStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.toolsSessions = new System.Windows.Forms.ToolStrip();
            this.toolsMap = new System.Windows.Forms.ToolStrip();
            this.lbSessions = new System.Windows.Forms.ListBox();
            this.btnUpdateSessions = new System.Windows.Forms.ToolStripButton();
            this.menuItemAction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConnectToServer = new System.Windows.Forms.ToolStripButton();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.cboxMapProviders = new System.Windows.Forms.ToolStripComboBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.toolsSessions.SuspendLayout();
            this.toolsMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemAction});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1099, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 701);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1099, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConnectToServer,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(167, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 24);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.lbSessions);
            this.splitMain.Panel1.Controls.Add(this.toolsSessions);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.gmap);
            this.splitMain.Panel2.Controls.Add(this.toolsMap);
            this.splitMain.Size = new System.Drawing.Size(1099, 677);
            this.splitMain.SplitterDistance = 243;
            this.splitMain.TabIndex = 3;
            // 
            // toolsSessions
            // 
            this.toolsSessions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnectToServer,
            this.btnUpdateSessions});
            this.toolsSessions.Location = new System.Drawing.Point(0, 0);
            this.toolsSessions.Name = "toolsSessions";
            this.toolsSessions.Size = new System.Drawing.Size(243, 25);
            this.toolsSessions.TabIndex = 0;
            this.toolsSessions.Text = "toolStrip1";
            // 
            // toolsMap
            // 
            this.toolsMap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboxMapProviders});
            this.toolsMap.Location = new System.Drawing.Point(0, 0);
            this.toolsMap.Name = "toolsMap";
            this.toolsMap.Size = new System.Drawing.Size(852, 25);
            this.toolsMap.TabIndex = 0;
            this.toolsMap.Text = "toolStrip2";
            // 
            // lbSessions
            // 
            this.lbSessions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSessions.FormattingEnabled = true;
            this.lbSessions.ItemHeight = 14;
            this.lbSessions.Location = new System.Drawing.Point(0, 25);
            this.lbSessions.Name = "lbSessions";
            this.lbSessions.Size = new System.Drawing.Size(243, 652);
            this.lbSessions.TabIndex = 1;
            this.lbSessions.SelectedIndexChanged += new System.EventHandler(this.lbSessions_SelectedIndexChanged);
            // 
            // btnUpdateSessions
            // 
            this.btnUpdateSessions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateSessions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSessions.Image")));
            this.btnUpdateSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSessions.Name = "btnUpdateSessions";
            this.btnUpdateSessions.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateSessions.Text = "toolStripButton1";
            this.btnUpdateSessions.Click += new System.EventHandler(this.menuItemUpdateSessions_Click);
            // 
            // menuItemAction
            // 
            this.menuItemAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUpdateSessions});
            this.menuItemAction.Name = "menuItemAction";
            this.menuItemAction.Size = new System.Drawing.Size(54, 20);
            this.menuItemAction.Text = "&Action";
            // 
            // menuItemUpdateSessions
            // 
            this.menuItemUpdateSessions.Name = "menuItemUpdateSessions";
            this.menuItemUpdateSessions.Size = new System.Drawing.Size(158, 22);
            this.menuItemUpdateSessions.Text = "&Update sessions";
            this.menuItemUpdateSessions.Click += new System.EventHandler(this.menuItemUpdateSessions_Click);
            // 
            // menuItemConnectToServer
            // 
            this.menuItemConnectToServer.Name = "menuItemConnectToServer";
            this.menuItemConnectToServer.Size = new System.Drawing.Size(167, 22);
            this.menuItemConnectToServer.Text = "&Connect to server";
            this.menuItemConnectToServer.Click += new System.EventHandler(this.menuItemConnectToServer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnectToServer.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectToServer.Image")));
            this.btnConnectToServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(23, 22);
            this.btnConnectToServer.Text = "toolStripButton1";
            this.btnConnectToServer.Click += new System.EventHandler(this.menuItemConnectToServer_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 25);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 4;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(852, 652);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 4D;
            // 
            // cboxMapProviders
            // 
            this.cboxMapProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMapProviders.Items.AddRange(new object[] {
            "Google Map",
            "Google Map Terrain",
            "Google Map Satellite",
            "Open Street Map",
            "Open Street Map Quest",
            "ArcGIS World Topo",
            "ArcGIS World 2D",
            "ArcGIS World Shaded",
            "Bing Map",
            "Bing Map Hybrid",
            "Bing Map Satellite",
            "Yahoo Map",
            "Yahoo Map Hybrid",
            "Yahoo Map Satellite"});
            this.cboxMapProviders.Name = "cboxMapProviders";
            this.cboxMapProviders.Size = new System.Drawing.Size(121, 25);
            this.cboxMapProviders.SelectedIndexChanged += new System.EventHandler(this.cboxMapProviders_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 723);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "Gamma Viewer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.toolsSessions.ResumeLayout(false);
            this.toolsSessions.PerformLayout();
            this.toolsMap.ResumeLayout(false);
            this.toolsMap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.ListBox lbSessions;
        private System.Windows.Forms.ToolStrip toolsSessions;
        private System.Windows.Forms.ToolStrip toolsMap;
        private System.Windows.Forms.ToolStripMenuItem menuItemAction;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateSessions;
        private System.Windows.Forms.ToolStripButton btnUpdateSessions;
        private System.Windows.Forms.ToolStripMenuItem menuItemConnectToServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConnectToServer;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ToolStripComboBox cboxMapProviders;
    }
}


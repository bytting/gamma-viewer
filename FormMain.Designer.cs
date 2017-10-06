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
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSyncSession = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRequestSessionList = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lbSessions = new System.Windows.Forms.ListBox();
            this.toolsSessions = new System.Windows.Forms.ToolStrip();
            this.btnConnectToServer = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSessions = new System.Windows.Forms.ToolStripButton();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.toolsMap = new System.Windows.Forms.ToolStrip();
            this.btnSyncSession = new System.Windows.Forms.ToolStripButton();
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
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1119, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSettings,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(116, 22);
            this.menuItemSettings.Text = "Settings";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(116, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemAction
            // 
            this.menuItemAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSyncSession,
            this.menuItemRequestSessionList});
            this.menuItemAction.Name = "menuItemAction";
            this.menuItemAction.Size = new System.Drawing.Size(54, 20);
            this.menuItemAction.Text = "Action";
            // 
            // menuItemSyncSession
            // 
            this.menuItemSyncSession.Name = "menuItemSyncSession";
            this.menuItemSyncSession.Size = new System.Drawing.Size(181, 22);
            this.menuItemSyncSession.Text = "Sync current session";
            this.menuItemSyncSession.Click += new System.EventHandler(this.menuItemSyncSession_Click);
            // 
            // menuItemRequestSessionList
            // 
            this.menuItemRequestSessionList.Name = "menuItemRequestSessionList";
            this.menuItemRequestSessionList.Size = new System.Drawing.Size(181, 22);
            this.menuItemRequestSessionList.Text = "Request session list";
            this.menuItemRequestSessionList.Click += new System.EventHandler(this.menuItemRequestSessionList_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 648);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.status.Size = new System.Drawing.Size(1119, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitMain.Size = new System.Drawing.Size(1119, 624);
            this.splitMain.SplitterDistance = 144;
            this.splitMain.SplitterWidth = 5;
            this.splitMain.TabIndex = 3;
            // 
            // lbSessions
            // 
            this.lbSessions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSessions.FormattingEnabled = true;
            this.lbSessions.ItemHeight = 15;
            this.lbSessions.Location = new System.Drawing.Point(0, 25);
            this.lbSessions.Name = "lbSessions";
            this.lbSessions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSessions.Size = new System.Drawing.Size(144, 599);
            this.lbSessions.TabIndex = 1;
            this.lbSessions.SelectedIndexChanged += new System.EventHandler(this.lbSessions_SelectedIndexChanged);
            // 
            // toolsSessions
            // 
            this.toolsSessions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsSessions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnectToServer,
            this.btnUpdateSessions});
            this.toolsSessions.Location = new System.Drawing.Point(0, 0);
            this.toolsSessions.Name = "toolsSessions";
            this.toolsSessions.Size = new System.Drawing.Size(144, 25);
            this.toolsSessions.TabIndex = 0;
            this.toolsSessions.Text = "toolStrip1";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnectToServer.Image = global::gamma_viewer.Properties.Resources.connect_32;
            this.btnConnectToServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(23, 22);
            this.btnConnectToServer.Text = "Set host";
            this.btnConnectToServer.ToolTipText = "Set IP address / Hostname of web service";
            this.btnConnectToServer.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // btnUpdateSessions
            // 
            this.btnUpdateSessions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdateSessions.Image = global::gamma_viewer.Properties.Resources.sessions_32;
            this.btnUpdateSessions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSessions.Name = "btnUpdateSessions";
            this.btnUpdateSessions.Size = new System.Drawing.Size(23, 22);
            this.btnUpdateSessions.Text = "Update session list";
            this.btnUpdateSessions.ToolTipText = "Get a fresh list of sessions from web service";
            this.btnUpdateSessions.Click += new System.EventHandler(this.menuItemRequestSessionList_Click);
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
            this.gmap.Size = new System.Drawing.Size(970, 599);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 9D;
            // 
            // toolsMap
            // 
            this.toolsMap.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSyncSession,
            this.cboxMapProviders});
            this.toolsMap.Location = new System.Drawing.Point(0, 0);
            this.toolsMap.Name = "toolsMap";
            this.toolsMap.Size = new System.Drawing.Size(970, 25);
            this.toolsMap.TabIndex = 0;
            this.toolsMap.Text = "toolStrip2";
            // 
            // btnSyncSession
            // 
            this.btnSyncSession.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSyncSession.Image = global::gamma_viewer.Properties.Resources.sync_32;
            this.btnSyncSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSyncSession.Name = "btnSyncSession";
            this.btnSyncSession.Size = new System.Drawing.Size(23, 22);
            this.btnSyncSession.Text = "Sync session";
            this.btnSyncSession.ToolTipText = "Sync current session with web service";
            this.btnSyncSession.Click += new System.EventHandler(this.menuItemSyncSession_Click);
            // 
            // cboxMapProviders
            // 
            this.cboxMapProviders.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cboxMapProviders.BackColor = System.Drawing.SystemColors.Window;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 670);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "Gamma Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
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
        private System.Windows.Forms.ToolStripButton btnUpdateSessions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConnectToServer;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ToolStripComboBox cboxMapProviders;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemAction;
        private System.Windows.Forms.ToolStripMenuItem menuItemSyncSession;
        private System.Windows.Forms.ToolStripButton btnSyncSession;
        private System.Windows.Forms.ToolStripMenuItem menuItemRequestSessionList;
    }
}


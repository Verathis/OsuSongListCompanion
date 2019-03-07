namespace OsuSongListCompanion
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.randomizerLabel = new System.Windows.Forms.Label();
            this.importExportLabel = new System.Windows.Forms.Label();
            this.tabControlBox = new System.Windows.Forms.TabControl();
            this.importExportTabPage = new System.Windows.Forms.TabPage();
            this.randomizerTabPage = new System.Windows.Forms.TabPage();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.importButton = new System.Windows.Forms.Button();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.exportButton = new System.Windows.Forms.Button();
            this.randomSongButton = new System.Windows.Forms.Button();
            this.randomSongBox = new System.Windows.Forms.TextBox();
            this.beatmapPageButton = new System.Windows.Forms.Button();
            this.aboutText = new System.Windows.Forms.Label();
            this.twitchLink = new System.Windows.Forms.LinkLabel();
            this.twitterLink = new System.Windows.Forms.LinkLabel();
            this.headerPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.tabControlBox.SuspendLayout();
            this.importExportTabPage.SuspendLayout();
            this.randomizerTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPanel.BackgroundImage")));
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 100);
            this.headerPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Location = new System.Drawing.Point(725, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeWindow);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(764, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseWindow);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.navigationPanel.Controls.Add(this.aboutLabel);
            this.navigationPanel.Controls.Add(this.randomizerLabel);
            this.navigationPanel.Controls.Add(this.importExportLabel);
            this.navigationPanel.Location = new System.Drawing.Point(0, 100);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 400);
            this.navigationPanel.TabIndex = 1;
            // 
            // aboutLabel
            // 
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutLabel.Location = new System.Drawing.Point(0, 361);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(200, 30);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "About";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // randomizerLabel
            // 
            this.randomizerLabel.BackColor = System.Drawing.Color.Transparent;
            this.randomizerLabel.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.randomizerLabel.Location = new System.Drawing.Point(0, 37);
            this.randomizerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.randomizerLabel.Name = "randomizerLabel";
            this.randomizerLabel.Size = new System.Drawing.Size(200, 30);
            this.randomizerLabel.TabIndex = 0;
            this.randomizerLabel.Text = "Randomizer";
            this.randomizerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.randomizerLabel.Click += new System.EventHandler(this.randomizerLabel_Click);
            // 
            // importExportLabel
            // 
            this.importExportLabel.BackColor = System.Drawing.Color.Transparent;
            this.importExportLabel.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importExportLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.importExportLabel.Location = new System.Drawing.Point(0, 7);
            this.importExportLabel.Margin = new System.Windows.Forms.Padding(0);
            this.importExportLabel.Name = "importExportLabel";
            this.importExportLabel.Size = new System.Drawing.Size(200, 30);
            this.importExportLabel.TabIndex = 0;
            this.importExportLabel.Text = "Import / Export";
            this.importExportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importExportLabel.Click += new System.EventHandler(this.importExportLabel_Click);
            // 
            // tabControlBox
            // 
            this.tabControlBox.Controls.Add(this.importExportTabPage);
            this.tabControlBox.Controls.Add(this.randomizerTabPage);
            this.tabControlBox.Controls.Add(this.aboutTabPage);
            this.tabControlBox.ItemSize = new System.Drawing.Size(30, 10);
            this.tabControlBox.Location = new System.Drawing.Point(189, 75);
            this.tabControlBox.Name = "tabControlBox";
            this.tabControlBox.SelectedIndex = 0;
            this.tabControlBox.Size = new System.Drawing.Size(623, 442);
            this.tabControlBox.TabIndex = 2;
            this.tabControlBox.TabStop = false;
            // 
            // importExportTabPage
            // 
            this.importExportTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.importExportTabPage.Controls.Add(this.exportButton);
            this.importExportTabPage.Controls.Add(this.importButton);
            this.importExportTabPage.Controls.Add(this.songsListBox);
            this.importExportTabPage.Location = new System.Drawing.Point(4, 14);
            this.importExportTabPage.Name = "importExportTabPage";
            this.importExportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.importExportTabPage.Size = new System.Drawing.Size(615, 424);
            this.importExportTabPage.TabIndex = 0;
            // 
            // randomizerTabPage
            // 
            this.randomizerTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.randomizerTabPage.Controls.Add(this.randomSongBox);
            this.randomizerTabPage.Controls.Add(this.beatmapPageButton);
            this.randomizerTabPage.Controls.Add(this.randomSongButton);
            this.randomizerTabPage.Location = new System.Drawing.Point(4, 14);
            this.randomizerTabPage.Name = "randomizerTabPage";
            this.randomizerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.randomizerTabPage.Size = new System.Drawing.Size(615, 424);
            this.randomizerTabPage.TabIndex = 1;
            // 
            // songsListBox
            // 
            this.songsListBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 19;
            this.songsListBox.Location = new System.Drawing.Point(39, 109);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(320, 194);
            this.songsListBox.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.importButton.FlatAppearance.BorderSize = 0;
            this.importButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.importButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.importButton.Location = new System.Drawing.Point(39, 38);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(120, 40);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.ImportSongs);
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTabPage.Controls.Add(this.twitterLink);
            this.aboutTabPage.Controls.Add(this.twitchLink);
            this.aboutTabPage.Controls.Add(this.aboutText);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 14);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Size = new System.Drawing.Size(615, 424);
            this.aboutTabPage.TabIndex = 2;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.exportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportButton.Location = new System.Drawing.Point(239, 38);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 40);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Visible = false;
            this.exportButton.Click += new System.EventHandler(this.ExportToFile);
            // 
            // randomSongButton
            // 
            this.randomSongButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.randomSongButton.FlatAppearance.BorderSize = 0;
            this.randomSongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.randomSongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.randomSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomSongButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomSongButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.randomSongButton.Location = new System.Drawing.Point(39, 38);
            this.randomSongButton.Name = "randomSongButton";
            this.randomSongButton.Size = new System.Drawing.Size(120, 40);
            this.randomSongButton.TabIndex = 1;
            this.randomSongButton.Text = "Randomize!";
            this.randomSongButton.UseVisualStyleBackColor = false;
            this.randomSongButton.Click += new System.EventHandler(this.ChooseRandomSong);
            // 
            // randomSongBox
            // 
            this.randomSongBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomSongBox.Location = new System.Drawing.Point(39, 85);
            this.randomSongBox.Name = "randomSongBox";
            this.randomSongBox.Size = new System.Drawing.Size(320, 27);
            this.randomSongBox.TabIndex = 2;
            // 
            // beatmapPageButton
            // 
            this.beatmapPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.beatmapPageButton.FlatAppearance.BorderSize = 0;
            this.beatmapPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.beatmapPageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.beatmapPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beatmapPageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beatmapPageButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.beatmapPageButton.Location = new System.Drawing.Point(239, 38);
            this.beatmapPageButton.Name = "beatmapPageButton";
            this.beatmapPageButton.Size = new System.Drawing.Size(120, 40);
            this.beatmapPageButton.TabIndex = 1;
            this.beatmapPageButton.Text = "Beatmap Page";
            this.beatmapPageButton.UseVisualStyleBackColor = false;
            this.beatmapPageButton.Click += new System.EventHandler(this.GoToSongPage);
            // 
            // aboutText
            // 
            this.aboutText.AutoSize = true;
            this.aboutText.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.aboutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.aboutText.Location = new System.Drawing.Point(39, 38);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(193, 54);
            this.aboutText.TabIndex = 0;
            this.aboutText.Text = "Version 0.2\r\nCreated by Verathis";
            // 
            // twitchLink
            // 
            this.twitchLink.AutoSize = true;
            this.twitchLink.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.twitchLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.twitchLink.Location = new System.Drawing.Point(44, 352);
            this.twitchLink.Name = "twitchLink";
            this.twitchLink.Size = new System.Drawing.Size(152, 27);
            this.twitchLink.TabIndex = 1;
            this.twitchLink.TabStop = true;
            this.twitchLink.Text = "Twitch Channel";
            this.twitchLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToTwitchPage);
            // 
            // twitterLink
            // 
            this.twitterLink.AutoSize = true;
            this.twitterLink.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.twitterLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.twitterLink.Location = new System.Drawing.Point(44, 325);
            this.twitterLink.Name = "twitterLink";
            this.twitterLink.Size = new System.Drawing.Size(76, 27);
            this.twitterLink.TabIndex = 1;
            this.twitterLink.TabStop = true;
            this.twitterLink.Text = "Twitter";
            this.twitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToTwitterPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.tabControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osu Song List Companion";
            this.headerPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.tabControlBox.ResumeLayout(false);
            this.importExportTabPage.ResumeLayout(false);
            this.randomizerTabPage.ResumeLayout(false);
            this.randomizerTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.aboutTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label importExportLabel;
        private System.Windows.Forms.Label randomizerLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.TabControl tabControlBox;
        private System.Windows.Forms.TabPage importExportTabPage;
        private System.Windows.Forms.TabPage randomizerTabPage;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ListBox songsListBox;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox randomSongBox;
        private System.Windows.Forms.Button randomSongButton;
        private System.Windows.Forms.Button beatmapPageButton;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.LinkLabel twitchLink;
        private System.Windows.Forms.LinkLabel twitterLink;
    }
}


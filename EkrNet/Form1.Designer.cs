
namespace EkrNet
{
    partial class mainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.favorite = new System.Windows.Forms.ListBox();
            this.history = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.webBrowser.Location = new System.Drawing.Point(102, 56);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1048, 628);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(1177, 27);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(1096, 27);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Précédent";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(0, 27);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(81, 27);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Rafraichir";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addressBar.Location = new System.Drawing.Point(401, 27);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(436, 20);
            this.addressBar.TabIndex = 6;
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // favorite
            // 
            this.favorite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.favorite.FormattingEnabled = true;
            this.favorite.Location = new System.Drawing.Point(0, 56);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(96, 615);
            this.favorite.TabIndex = 7;
            this.favorite.SelectedIndexChanged += new System.EventHandler(this.favorite_SelectedIndexChanged);
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(1156, 56);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(96, 615);
            this.history.TabIndex = 8;
            this.history.SelectedIndexChanged += new System.EventHandler(this.history_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(843, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 20);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.favorite);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkrNet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.ListBox favorite;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


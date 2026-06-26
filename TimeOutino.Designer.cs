namespace TimeOutino
{
    partial class TimeOutino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeOutino));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslab = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgrbr = new System.Windows.Forms.ToolStripProgressBar();
            this.nMinutiTot = new System.Windows.Forms.NumericUpDown();
            this.timerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPausaOgni = new System.Windows.Forms.Label();
            this.lblRiparti = new System.Windows.Forms.Label();
            this.restartcomb = new System.Windows.Forms.ComboBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.tabTutto = new System.Windows.Forms.TabControl();
            this.tabPrincipale = new System.Windows.Forms.TabPage();
            this.btnconfig = new System.Windows.Forms.Button();
            this.tabNotifica = new System.Windows.Forms.TabPage();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.btnlocal = new System.Windows.Forms.Button();
            this.lblAudioLocale = new System.Windows.Forms.Label();
            this.txtAudioLocale = new System.Windows.Forms.TextBox();
            this.panelFrasi = new System.Windows.Forms.GroupBox();
            this.txtFrasi = new System.Windows.Forms.TextBox();
            this.notifiycomb = new System.Windows.Forms.ComboBox();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.IconaBassa = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutiTot)).BeginInit();
            this.timerLayout.SuspendLayout();
            this.tabTutto.SuspendLayout();
            this.tabPrincipale.SuspendLayout();
            this.tabNotifica.SuspendLayout();
            this.panelLocal.SuspendLayout();
            this.panelFrasi.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(236, 239, 241);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslab,
            this.prgrbr});
            this.statusStrip1.Location = new System.Drawing.Point(3, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslab
            // 
            this.statuslab.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.statuslab.Name = "statuslab";
            this.statuslab.Size = new System.Drawing.Size(40, 25);
            this.statuslab.Text = "---";
            // 
            // prgrbr
            // 
            this.prgrbr.Name = "prgrbr";
            this.prgrbr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prgrbr.Size = new System.Drawing.Size(100, 24);
            this.prgrbr.Step = 1;
            this.prgrbr.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // nMinutiTot
            // 
            this.nMinutiTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nMinutiTot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nMinutiTot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMinutiTot.ForeColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.nMinutiTot.Location = new System.Drawing.Point(101, 3);
            this.nMinutiTot.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nMinutiTot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMinutiTot.Name = "nMinutiTot";
            this.nMinutiTot.Size = new System.Drawing.Size(225, 48);
            this.nMinutiTot.TabIndex = 4;
            this.nMinutiTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nMinutiTot.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // timerLayout
            // 
            this.timerLayout.ColumnCount = 2;
            this.timerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.timerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.timerLayout.Controls.Add(this.nMinutiTot, 1, 0);
            this.timerLayout.Controls.Add(this.lblPausaOgni, 0, 0);
            this.timerLayout.Controls.Add(this.lblRiparti, 0, 1);
            this.timerLayout.Controls.Add(this.restartcomb, 1, 1);
            this.timerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerLayout.Location = new System.Drawing.Point(3, 3);
            this.timerLayout.Name = "timerLayout";
            this.timerLayout.RowCount = 3;
            this.timerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.timerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.timerLayout.Size = new System.Drawing.Size(329, 161);
            this.timerLayout.TabIndex = 5;
            // 
            // lblPausaOgni
            // 
            this.lblPausaOgni.AutoSize = true;
            this.lblPausaOgni.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblPausaOgni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPausaOgni.Location = new System.Drawing.Point(3, 0);
            this.lblPausaOgni.Name = "lblPausaOgni";
            this.lblPausaOgni.Size = new System.Drawing.Size(92, 54);
            this.lblPausaOgni.TabIndex = 5;
            this.lblPausaOgni.Text = "Pausa ogni (min)";
            this.lblPausaOgni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRiparti
            // 
            this.lblRiparti.AutoSize = true;
            this.lblRiparti.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblRiparti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRiparti.Location = new System.Drawing.Point(3, 54);
            this.lblRiparti.Name = "lblRiparti";
            this.lblRiparti.Size = new System.Drawing.Size(92, 34);
            this.lblRiparti.TabIndex = 6;
            this.lblRiparti.Text = "Riparti";
            this.lblRiparti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restartcomb
            // 
            this.restartcomb.BackColor = System.Drawing.Color.White;
            this.restartcomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartcomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restartcomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartcomb.FormattingEnabled = true;
            this.restartcomb.Location = new System.Drawing.Point(101, 57);
            this.restartcomb.Name = "restartcomb";
            this.restartcomb.Size = new System.Drawing.Size(225, 28);
            this.restartcomb.TabIndex = 7;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(3, 3);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 256);
            this.splitter.TabIndex = 6;
            this.splitter.TabStop = false;
            // 
            // tabTutto
            // 
            this.tabTutto.Controls.Add(this.tabPrincipale);
            this.tabTutto.Controls.Add(this.tabNotifica);
            this.tabTutto.Controls.Add(this.TabConfig);
            this.tabTutto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTutto.Location = new System.Drawing.Point(6, 3);
            this.tabTutto.Name = "tabTutto";
            this.tabTutto.Padding = new System.Drawing.Point(9, 6);
            this.tabTutto.SelectedIndex = 0;
            this.tabTutto.Size = new System.Drawing.Size(369, 256);
            this.tabTutto.TabIndex = 7;
            // 
            // tabPrincipale
            // 
            this.tabPrincipale.Controls.Add(this.btnconfig);
            this.tabPrincipale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPrincipale.Location = new System.Drawing.Point(4, 35);
            this.tabPrincipale.Name = "tabPrincipale";
            this.tabPrincipale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipale.Size = new System.Drawing.Size(361, 217);
            this.tabPrincipale.TabIndex = 2;
            this.tabPrincipale.Text = "TimeOutino";
            this.tabPrincipale.BackColor = System.Drawing.Color.White;
            this.tabPrincipale.UseVisualStyleBackColor = false;
            // 
            // btnconfig
            // 
            this.btnconfig.BackColor = System.Drawing.Color.White;
            this.btnconfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconfig.BackgroundImage")));
            this.btnconfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconfig.FlatAppearance.BorderSize = 0;
            this.btnconfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(178, 223, 219);
            this.btnconfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 242, 241);
            this.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnconfig.Location = new System.Drawing.Point(3, 3);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(355, 211);
            this.btnconfig.TabIndex = 1;
            this.btnconfig.UseVisualStyleBackColor = false;
            this.btnconfig.Click += new System.EventHandler(this.ToggleBTNClick);
            // 
            // tabNotifica
            // 
            this.tabNotifica.Controls.Add(this.panelLocal);
            this.tabNotifica.Controls.Add(this.panelFrasi);
            this.tabNotifica.Controls.Add(this.notifiycomb);
            this.tabNotifica.Location = new System.Drawing.Point(4, 35);
            this.tabNotifica.Name = "tabNotifica";
            this.tabNotifica.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotifica.Size = new System.Drawing.Size(261, 167);
            this.tabNotifica.TabIndex = 0;
            this.tabNotifica.Text = "Notifica";
            this.tabNotifica.BackColor = System.Drawing.Color.White;
            this.tabNotifica.UseVisualStyleBackColor = false;
            // 
            // panelLocal
            // 
            this.panelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLocal.Controls.Add(this.btnlocal);
            this.panelLocal.Controls.Add(this.lblAudioLocale);
            this.panelLocal.Controls.Add(this.txtAudioLocale);
            this.panelLocal.BackColor = System.Drawing.Color.Transparent;
            this.panelLocal.Location = new System.Drawing.Point(3, 37);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(252, 72);
            this.panelLocal.TabIndex = 1;
            // 
            // btnlocal
            // 
            this.btnlocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlocal.BackColor = System.Drawing.Color.White;
            this.btnlocal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(38, 166, 154);
            this.btnlocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 242, 241);
            this.btnlocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocal.ForeColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.btnlocal.Location = new System.Drawing.Point(209, 15);
            this.btnlocal.Name = "btnlocal";
            this.btnlocal.Size = new System.Drawing.Size(40, 40);
            this.btnlocal.TabIndex = 2;
            this.btnlocal.Text = "...";
            this.btnlocal.UseVisualStyleBackColor = false;
            this.btnlocal.Click += new System.EventHandler(this.SceglifileEvent);
            // 
            // lblAudioLocale
            // 
            this.lblAudioLocale.AutoSize = true;
            this.lblAudioLocale.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.lblAudioLocale.Location = new System.Drawing.Point(3, 25);
            this.lblAudioLocale.Name = "lblAudioLocale";
            this.lblAudioLocale.Size = new System.Drawing.Size(95, 20);
            this.lblAudioLocale.TabIndex = 1;
            this.lblAudioLocale.Text = "Audio locale";
            // 
            // txtAudioLocale
            // 
            this.txtAudioLocale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAudioLocale.BackColor = System.Drawing.Color.White;
            this.txtAudioLocale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAudioLocale.Location = new System.Drawing.Point(104, 22);
            this.txtAudioLocale.Name = "txtAudioLocale";
            this.txtAudioLocale.ReadOnly = true;
            this.txtAudioLocale.Size = new System.Drawing.Size(99, 26);
            this.txtAudioLocale.TabIndex = 0;
            this.txtAudioLocale.DoubleClick += new System.EventHandler(this.SceglifileEvent);
            // 
            // panelFrasi
            // 
            this.panelFrasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrasi.BackColor = System.Drawing.Color.Transparent;
            this.panelFrasi.Controls.Add(this.txtFrasi);
            this.panelFrasi.ForeColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.panelFrasi.Location = new System.Drawing.Point(6, 37);
            this.panelFrasi.Name = "panelFrasi";
            this.panelFrasi.Size = new System.Drawing.Size(252, 131);
            this.panelFrasi.TabIndex = 2;
            this.panelFrasi.TabStop = false;
            this.panelFrasi.Text = "Set di frasi";
            // 
            // txtFrasi
            // 
            this.txtFrasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrasi.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.txtFrasi.Location = new System.Drawing.Point(3, 22);
            this.txtFrasi.Multiline = true;
            this.txtFrasi.Name = "txtFrasi";
            this.txtFrasi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFrasi.Size = new System.Drawing.Size(246, 106);
            this.txtFrasi.TabIndex = 1;
            // 
            // notifiycomb
            // 
            this.notifiycomb.BackColor = System.Drawing.Color.White;
            this.notifiycomb.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifiycomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notifiycomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifiycomb.FormattingEnabled = true;
            this.notifiycomb.Location = new System.Drawing.Point(3, 3);
            this.notifiycomb.Name = "notifiycomb";
            this.notifiycomb.Size = new System.Drawing.Size(255, 28);
            this.notifiycomb.TabIndex = 0;
            this.notifiycomb.SelectedIndexChanged += new System.EventHandler(this.CambiaTipoNotifica);
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.timerLayout);
            this.TabConfig.Location = new System.Drawing.Point(4, 35);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfig.Size = new System.Drawing.Size(335, 167);
            this.TabConfig.TabIndex = 1;
            this.TabConfig.Text = "Timer";
            this.TabConfig.BackColor = System.Drawing.Color.White;
            this.TabConfig.UseVisualStyleBackColor = false;
            // 
            // IconaBassa
            // 
            this.IconaBassa.Icon = ((System.Drawing.Icon)(resources.GetObject("IconaBassa.Icon")));
            this.IconaBassa.Text = "TimeOutino";
            this.IconaBassa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RiapriDaNascosto);
            // 
            // TimeOutino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            this.ClientSize = new System.Drawing.Size(378, 294);
            this.Controls.Add(this.tabTutto);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "TimeOutino";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeOutino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInChiusura);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Resize += new System.EventHandler(this.RidimensionaForm);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutiTot)).EndInit();
            this.timerLayout.ResumeLayout(false);
            this.timerLayout.PerformLayout();
            this.tabTutto.ResumeLayout(false);
            this.tabPrincipale.ResumeLayout(false);
            this.tabNotifica.ResumeLayout(false);
            this.panelLocal.ResumeLayout(false);
            this.panelLocal.PerformLayout();
            this.panelFrasi.ResumeLayout(false);
            this.panelFrasi.PerformLayout();
            this.TabConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NumericUpDown nMinutiTot;
        private System.Windows.Forms.TableLayoutPanel timerLayout;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Label lblPausaOgni;
        private System.Windows.Forms.ToolStripStatusLabel statuslab;
        private System.Windows.Forms.TabControl tabTutto;
        private System.Windows.Forms.TabPage TabConfig;
        private System.Windows.Forms.Button btnconfig;
        private System.Windows.Forms.ToolStripProgressBar prgrbr;
        private System.Windows.Forms.Label lblRiparti;
        private System.Windows.Forms.ComboBox restartcomb;
        private System.Windows.Forms.TabPage tabNotifica;
        private System.Windows.Forms.ComboBox notifiycomb;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.Label lblAudioLocale;
        private System.Windows.Forms.TextBox txtAudioLocale;
        private System.Windows.Forms.TabPage tabPrincipale;
        private System.Windows.Forms.Button btnlocal;
        private System.Windows.Forms.TextBox txtFrasi;
        private System.Windows.Forms.GroupBox panelFrasi;
        private System.Windows.Forms.NotifyIcon IconaBassa;
    }
}


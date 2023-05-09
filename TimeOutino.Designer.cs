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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restartcomb = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabTutto = new System.Windows.Forms.TabControl();
            this.tabPrincipale = new System.Windows.Forms.TabPage();
            this.btnconfig = new System.Windows.Forms.Button();
            this.tabNotifica = new System.Windows.Forms.TabPage();
            this.panelLocal = new System.Windows.Forms.Panel();
            this.btnlocal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAudioLocale = new System.Windows.Forms.TextBox();
            this.panelFrasi = new System.Windows.Forms.GroupBox();
            this.txtFrasi = new System.Windows.Forms.TextBox();
            this.notifiycomb = new System.Windows.Forms.ComboBox();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.IconaBassa = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutiTot)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.statuslab.Name = "statuslab";
            this.statuslab.Size = new System.Drawing.Size(40, 25);
            this.statuslab.Text = "----";
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
            this.nMinutiTot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nMinutiTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.nMinutiTot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.restartcomb, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 161);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pausa ogni (min)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Riparti";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restartcomb
            // 
            this.restartcomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartcomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restartcomb.FormattingEnabled = true;
            this.restartcomb.Location = new System.Drawing.Point(101, 57);
            this.restartcomb.Name = "restartcomb";
            this.restartcomb.Size = new System.Drawing.Size(225, 28);
            this.restartcomb.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 256);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
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
            this.tabPrincipale.UseVisualStyleBackColor = true;
            // 
            // btnconfig
            // 
            this.btnconfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconfig.BackgroundImage")));
            this.btnconfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnconfig.Location = new System.Drawing.Point(3, 3);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(355, 211);
            this.btnconfig.TabIndex = 1;
            this.btnconfig.UseVisualStyleBackColor = true;
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
            this.tabNotifica.UseVisualStyleBackColor = true;
            // 
            // panelLocal
            // 
            this.panelLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLocal.Controls.Add(this.btnlocal);
            this.panelLocal.Controls.Add(this.label3);
            this.panelLocal.Controls.Add(this.txtAudioLocale);
            this.panelLocal.Location = new System.Drawing.Point(3, 37);
            this.panelLocal.Name = "panelLocal";
            this.panelLocal.Size = new System.Drawing.Size(252, 72);
            this.panelLocal.TabIndex = 1;
            // 
            // btnlocal
            // 
            this.btnlocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlocal.Location = new System.Drawing.Point(209, 15);
            this.btnlocal.Name = "btnlocal";
            this.btnlocal.Size = new System.Drawing.Size(40, 40);
            this.btnlocal.TabIndex = 2;
            this.btnlocal.Text = "...";
            this.btnlocal.UseVisualStyleBackColor = true;
            this.btnlocal.Click += new System.EventHandler(this.SceglifileEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Audio locale";
            // 
            // txtAudioLocale
            // 
            this.txtAudioLocale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelFrasi.Controls.Add(this.txtFrasi);
            this.panelFrasi.Location = new System.Drawing.Point(6, 37);
            this.panelFrasi.Name = "panelFrasi";
            this.panelFrasi.Size = new System.Drawing.Size(252, 131);
            this.panelFrasi.TabIndex = 2;
            this.panelFrasi.TabStop = false;
            this.panelFrasi.Text = "Set di frasi";
            // 
            // txtFrasi
            // 
            this.txtFrasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrasi.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrasi.Location = new System.Drawing.Point(3, 22);
            this.txtFrasi.Multiline = true;
            this.txtFrasi.Name = "txtFrasi";
            this.txtFrasi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFrasi.Size = new System.Drawing.Size(246, 106);
            this.txtFrasi.TabIndex = 1;
            // 
            // notifiycomb
            // 
            this.notifiycomb.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifiycomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notifiycomb.FormattingEnabled = true;
            this.notifiycomb.Location = new System.Drawing.Point(3, 3);
            this.notifiycomb.Name = "notifiycomb";
            this.notifiycomb.Size = new System.Drawing.Size(255, 28);
            this.notifiycomb.TabIndex = 0;
            this.notifiycomb.SelectedIndexChanged += new System.EventHandler(this.CambiaTipoNotifica);
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.tableLayoutPanel1);
            this.TabConfig.Location = new System.Drawing.Point(4, 35);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfig.Size = new System.Drawing.Size(335, 167);
            this.TabConfig.TabIndex = 1;
            this.TabConfig.Text = "Timer";
            this.TabConfig.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(378, 294);
            this.Controls.Add(this.tabTutto);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "TimeOutino";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeOutino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInChiusura);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.RidimensionaForm);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutiTot)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel statuslab;
        private System.Windows.Forms.TabControl tabTutto;
        private System.Windows.Forms.TabPage TabConfig;
        private System.Windows.Forms.Button btnconfig;
        private System.Windows.Forms.ToolStripProgressBar prgrbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox restartcomb;
        private System.Windows.Forms.TabPage tabNotifica;
        private System.Windows.Forms.ComboBox notifiycomb;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAudioLocale;
        private System.Windows.Forms.TabPage tabPrincipale;
        private System.Windows.Forms.Button btnlocal;
        private System.Windows.Forms.TextBox txtFrasi;
        private System.Windows.Forms.GroupBox panelFrasi;
        private System.Windows.Forms.NotifyIcon IconaBassa;
    }
}


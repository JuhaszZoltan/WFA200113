namespace WFA200113
{
    partial class FrmDiak
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAzon = new System.Windows.Forms.TextBox();
            this.cbIskola = new System.Windows.Forms.ComboBox();
            this.nudEvf = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üresŰrlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvf)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // tbAzon
            // 
            this.tbAzon.Enabled = false;
            this.tbAzon.Location = new System.Drawing.Point(109, 34);
            this.tbAzon.Name = "tbAzon";
            this.tbAzon.Size = new System.Drawing.Size(79, 22);
            this.tbAzon.TabIndex = 1;
            // 
            // cbIskola
            // 
            this.cbIskola.FormattingEnabled = true;
            this.cbIskola.Location = new System.Drawing.Point(109, 169);
            this.cbIskola.Name = "cbIskola";
            this.cbIskola.Size = new System.Drawing.Size(163, 24);
            this.cbIskola.TabIndex = 2;
            // 
            // nudEvf
            // 
            this.nudEvf.Location = new System.Drawing.Point(109, 125);
            this.nudEvf.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudEvf.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudEvf.Name = "nudEvf";
            this.nudEvf.Size = new System.Drawing.Size(79, 22);
            this.nudEvf.TabIndex = 3;
            this.nudEvf.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.keresésToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.üresŰrlapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 249);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 64);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 60);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::WFA200113.Properties.Resources.keres;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(73, 60);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.KeresesTSMI_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Image = global::WFA200113.Properties.Resources.save;
            this.mentésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(71, 60);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.MentesTSMI_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Image = global::WFA200113.Properties.Resources.delete;
            this.törlésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(62, 60);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.TorlesTSMI_Click);
            // 
            // üresŰrlapToolStripMenuItem
            // 
            this.üresŰrlapToolStripMenuItem.Image = global::WFA200113.Properties.Resources.ures_urlap;
            this.üresŰrlapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.üresŰrlapToolStripMenuItem.Name = "üresŰrlapToolStripMenuItem";
            this.üresŰrlapToolStripMenuItem.Size = new System.Drawing.Size(90, 60);
            this.üresŰrlapToolStripMenuItem.Text = "Üres űrlap";
            this.üresŰrlapToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Évfolyam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Iskola:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(109, 77);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(163, 22);
            this.tbNev.TabIndex = 1;
            // 
            // FrmDiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 313);
            this.Controls.Add(this.nudEvf);
            this.Controls.Add(this.cbIskola);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbAzon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDiak";
            this.Text = "Diák";
            this.Load += new System.EventHandler(this.FrmDiak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEvf)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAzon;
        private System.Windows.Forms.ComboBox cbIskola;
        private System.Windows.Forms.NumericUpDown nudEvf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üresŰrlapToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
    }
}
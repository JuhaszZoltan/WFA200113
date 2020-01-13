namespace WFA200113
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iskolákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredményekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHelyezesek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelyezesek)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iskolákToolStripMenuItem,
            this.diákokToolStripMenuItem,
            this.feladatokToolStripMenuItem,
            this.eredményekToolStripMenuItem,
            this.kilépToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 92);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iskolákToolStripMenuItem
            // 
            this.iskolákToolStripMenuItem.Image = global::WFA200113.Properties.Resources.school;
            this.iskolákToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iskolákToolStripMenuItem.Name = "iskolákToolStripMenuItem";
            this.iskolákToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.iskolákToolStripMenuItem.Text = "Iskolák";
            this.iskolákToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // diákokToolStripMenuItem
            // 
            this.diákokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.diákokToolStripMenuItem.Image = global::WFA200113.Properties.Resources.student1;
            this.diákokToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diákokToolStripMenuItem.Name = "diákokToolStripMenuItem";
            this.diákokToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.diákokToolStripMenuItem.Text = "Diákok";
            this.diákokToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.SzerkesztesTSMI_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.KeresesTSMI_Click);
            // 
            // feladatokToolStripMenuItem
            // 
            this.feladatokToolStripMenuItem.Image = global::WFA200113.Properties.Resources.task;
            this.feladatokToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feladatokToolStripMenuItem.Name = "feladatokToolStripMenuItem";
            this.feladatokToolStripMenuItem.Size = new System.Drawing.Size(88, 88);
            this.feladatokToolStripMenuItem.Text = "Feladatok";
            this.feladatokToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // eredményekToolStripMenuItem
            // 
            this.eredményekToolStripMenuItem.Image = global::WFA200113.Properties.Resources.results;
            this.eredményekToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eredményekToolStripMenuItem.Name = "eredményekToolStripMenuItem";
            this.eredményekToolStripMenuItem.Size = new System.Drawing.Size(111, 88);
            this.eredményekToolStripMenuItem.Text = "Eredmények";
            this.eredményekToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kilépToolStripMenuItem
            // 
            this.kilépToolStripMenuItem.Image = global::WFA200113.Properties.Resources.exit;
            this.kilépToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            this.kilépToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.kilépToolStripMenuItem.Text = "Kilép";
            this.kilépToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvHelyezesek
            // 
            this.dgvHelyezesek.AllowUserToAddRows = false;
            this.dgvHelyezesek.AllowUserToDeleteRows = false;
            this.dgvHelyezesek.AllowUserToResizeColumns = false;
            this.dgvHelyezesek.AllowUserToResizeRows = false;
            this.dgvHelyezesek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHelyezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHelyezesek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHelyezesek.Location = new System.Drawing.Point(12, 152);
            this.dgvHelyezesek.Name = "dgvHelyezesek";
            this.dgvHelyezesek.RowHeadersVisible = false;
            this.dgvHelyezesek.RowHeadersWidth = 51;
            this.dgvHelyezesek.RowTemplate.Height = 24;
            this.dgvHelyezesek.Size = new System.Drawing.Size(711, 297);
            this.dgvHelyezesek.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "Hely";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 3F;
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 1F;
            this.Column3.HeaderText = "Pont";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 1F;
            this.Column4.HeaderText = "Évf.";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 5F;
            this.Column5.HeaderText = "Iskola";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "A 2014/15 évi verseny rangsora";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHelyezesek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Matematika Pontverseny";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelyezesek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iskolákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredményekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHelyezesek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
    }
}


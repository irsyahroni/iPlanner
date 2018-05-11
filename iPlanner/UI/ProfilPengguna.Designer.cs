namespace iPlanner.UI
{
    partial class ProfilPengguna
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
            this.Profil_table = new System.Windows.Forms.TableLayoutPanel();
            this.Button_table = new System.Windows.Forms.TableLayoutPanel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Riwayat_table = new System.Windows.Forms.TableLayoutPanel();
            this.NilaiIPK_label = new System.Windows.Forms.Label();
            this.NilaiSKSTotal_label = new System.Windows.Forms.Label();
            this.IpTerakhir_label = new System.Windows.Forms.Label();
            this.SksTerakhir_label = new System.Windows.Forms.Label();
            this.Ip_label = new System.Windows.Forms.Label();
            this.Sks_label = new System.Windows.Forms.Label();
            this.IPK_label = new System.Windows.Forms.Label();
            this.SksTotal_label = new System.Windows.Forms.Label();
            this.Biodata_table = new System.Windows.Forms.TableLayoutPanel();
            this.Semester_label = new System.Windows.Forms.Label();
            this.SemesterUser_label = new System.Windows.Forms.Label();
            this.AngkatanUser_label = new System.Windows.Forms.Label();
            this.Angkatan_label = new System.Windows.Forms.Label();
            this.JurusanUser_label = new System.Windows.Forms.Label();
            this.Jurusan_label = new System.Windows.Forms.Label();
            this.NimUser_label = new System.Windows.Forms.Label();
            this.Nim_label = new System.Windows.Forms.Label();
            this.NamaUser_label = new System.Windows.Forms.Label();
            this.Nama_label = new System.Windows.Forms.Label();
            this.Profile_Picture = new System.Windows.Forms.PictureBox();
            this.Profil_table.SuspendLayout();
            this.Button_table.SuspendLayout();
            this.Riwayat_table.SuspendLayout();
            this.Biodata_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Profil_table
            // 
            this.Profil_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Profil_table.ColumnCount = 2;
            this.Profil_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.67647F));
            this.Profil_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.32353F));
            this.Profil_table.Controls.Add(this.Button_table, 0, 1);
            this.Profil_table.Controls.Add(this.Riwayat_table, 1, 1);
            this.Profil_table.Controls.Add(this.Biodata_table, 1, 0);
            this.Profil_table.Controls.Add(this.Profile_Picture, 0, 0);
            this.Profil_table.Location = new System.Drawing.Point(12, 12);
            this.Profil_table.Name = "Profil_table";
            this.Profil_table.RowCount = 2;
            this.Profil_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.86385F));
            this.Profil_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.13615F));
            this.Profil_table.Size = new System.Drawing.Size(409, 426);
            this.Profil_table.TabIndex = 0;
            // 
            // Button_table
            // 
            this.Button_table.ColumnCount = 1;
            this.Button_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Button_table.Controls.Add(this.Exit_button, 0, 0);
            this.Button_table.Location = new System.Drawing.Point(4, 144);
            this.Button_table.Name = "Button_table";
            this.Button_table.RowCount = 3;
            this.Button_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.Button_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.Button_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.Button_table.Size = new System.Drawing.Size(110, 133);
            this.Button_table.TabIndex = 2;
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.Location = new System.Drawing.Point(3, 3);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(104, 22);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Riwayat_table
            // 
            this.Riwayat_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Riwayat_table.ColumnCount = 2;
            this.Riwayat_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Riwayat_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Riwayat_table.Controls.Add(this.NilaiIPK_label, 0, 3);
            this.Riwayat_table.Controls.Add(this.NilaiSKSTotal_label, 0, 3);
            this.Riwayat_table.Controls.Add(this.IpTerakhir_label, 0, 0);
            this.Riwayat_table.Controls.Add(this.SksTerakhir_label, 1, 0);
            this.Riwayat_table.Controls.Add(this.Ip_label, 0, 1);
            this.Riwayat_table.Controls.Add(this.Sks_label, 1, 1);
            this.Riwayat_table.Controls.Add(this.IPK_label, 0, 2);
            this.Riwayat_table.Controls.Add(this.SksTotal_label, 1, 2);
            this.Riwayat_table.Location = new System.Drawing.Point(121, 144);
            this.Riwayat_table.Name = "Riwayat_table";
            this.Riwayat_table.RowCount = 4;
            this.Riwayat_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
            this.Riwayat_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
            this.Riwayat_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.Riwayat_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.Riwayat_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Riwayat_table.Size = new System.Drawing.Size(284, 190);
            this.Riwayat_table.TabIndex = 1;
            // 
            // NilaiIPK_label
            // 
            this.NilaiIPK_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NilaiIPK_label.AutoSize = true;
            this.NilaiIPK_label.Location = new System.Drawing.Point(4, 145);
            this.NilaiIPK_label.Name = "NilaiIPK_label";
            this.NilaiIPK_label.Size = new System.Drawing.Size(134, 13);
            this.NilaiIPK_label.TabIndex = 8;
            this.NilaiIPK_label.Text = "3.16";
            this.NilaiIPK_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NilaiSKSTotal_label
            // 
            this.NilaiSKSTotal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NilaiSKSTotal_label.AutoSize = true;
            this.NilaiSKSTotal_label.Location = new System.Drawing.Point(145, 145);
            this.NilaiSKSTotal_label.Name = "NilaiSKSTotal_label";
            this.NilaiSKSTotal_label.Size = new System.Drawing.Size(135, 13);
            this.NilaiSKSTotal_label.TabIndex = 7;
            this.NilaiSKSTotal_label.Text = "44";
            this.NilaiSKSTotal_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IpTerakhir_label
            // 
            this.IpTerakhir_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IpTerakhir_label.AutoSize = true;
            this.IpTerakhir_label.Location = new System.Drawing.Point(4, 6);
            this.IpTerakhir_label.Name = "IpTerakhir_label";
            this.IpTerakhir_label.Size = new System.Drawing.Size(134, 13);
            this.IpTerakhir_label.TabIndex = 1;
            this.IpTerakhir_label.Text = "IP Terakhir";
            // 
            // SksTerakhir_label
            // 
            this.SksTerakhir_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SksTerakhir_label.AutoSize = true;
            this.SksTerakhir_label.Location = new System.Drawing.Point(145, 6);
            this.SksTerakhir_label.Name = "SksTerakhir_label";
            this.SksTerakhir_label.Size = new System.Drawing.Size(135, 13);
            this.SksTerakhir_label.TabIndex = 3;
            this.SksTerakhir_label.Text = "Jumlah SKS Terakhir";
            // 
            // Ip_label
            // 
            this.Ip_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Ip_label.AutoSize = true;
            this.Ip_label.Location = new System.Drawing.Point(4, 50);
            this.Ip_label.Name = "Ip_label";
            this.Ip_label.Size = new System.Drawing.Size(134, 13);
            this.Ip_label.TabIndex = 2;
            this.Ip_label.Text = "3.25";
            this.Ip_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sks_label
            // 
            this.Sks_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sks_label.AutoSize = true;
            this.Sks_label.Location = new System.Drawing.Point(145, 50);
            this.Sks_label.Name = "Sks_label";
            this.Sks_label.Size = new System.Drawing.Size(135, 13);
            this.Sks_label.TabIndex = 4;
            this.Sks_label.Text = "24";
            this.Sks_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPK_label
            // 
            this.IPK_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPK_label.AutoSize = true;
            this.IPK_label.Location = new System.Drawing.Point(4, 94);
            this.IPK_label.Name = "IPK_label";
            this.IPK_label.Size = new System.Drawing.Size(134, 13);
            this.IPK_label.TabIndex = 6;
            this.IPK_label.Text = "IPK";
            // 
            // SksTotal_label
            // 
            this.SksTotal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SksTotal_label.AutoSize = true;
            this.SksTotal_label.Location = new System.Drawing.Point(145, 94);
            this.SksTotal_label.Name = "SksTotal_label";
            this.SksTotal_label.Size = new System.Drawing.Size(135, 13);
            this.SksTotal_label.TabIndex = 5;
            this.SksTotal_label.Text = "Total SKS";
            // 
            // Biodata_table
            // 
            this.Biodata_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Biodata_table.ColumnCount = 2;
            this.Biodata_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98507F));
            this.Biodata_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.01492F));
            this.Biodata_table.Controls.Add(this.Semester_label, 0, 4);
            this.Biodata_table.Controls.Add(this.SemesterUser_label, 0, 4);
            this.Biodata_table.Controls.Add(this.AngkatanUser_label, 1, 3);
            this.Biodata_table.Controls.Add(this.Angkatan_label, 0, 3);
            this.Biodata_table.Controls.Add(this.JurusanUser_label, 1, 2);
            this.Biodata_table.Controls.Add(this.Jurusan_label, 0, 2);
            this.Biodata_table.Controls.Add(this.NimUser_label, 1, 1);
            this.Biodata_table.Controls.Add(this.Nim_label, 0, 1);
            this.Biodata_table.Controls.Add(this.NamaUser_label, 1, 0);
            this.Biodata_table.Controls.Add(this.Nama_label, 0, 0);
            this.Biodata_table.Location = new System.Drawing.Point(121, 4);
            this.Biodata_table.Name = "Biodata_table";
            this.Biodata_table.RowCount = 5;
            this.Biodata_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.Biodata_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.Biodata_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Biodata_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.Biodata_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Biodata_table.Size = new System.Drawing.Size(284, 104);
            this.Biodata_table.TabIndex = 0;
            // 
            // Semester_label
            // 
            this.Semester_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Semester_label.AutoSize = true;
            this.Semester_label.Location = new System.Drawing.Point(4, 86);
            this.Semester_label.Name = "Semester_label";
            this.Semester_label.Size = new System.Drawing.Size(72, 13);
            this.Semester_label.TabIndex = 9;
            this.Semester_label.Text = "Semester";
            // 
            // SemesterUser_label
            // 
            this.SemesterUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SemesterUser_label.AutoSize = true;
            this.SemesterUser_label.Location = new System.Drawing.Point(83, 86);
            this.SemesterUser_label.Name = "SemesterUser_label";
            this.SemesterUser_label.Size = new System.Drawing.Size(197, 13);
            this.SemesterUser_label.TabIndex = 8;
            this.SemesterUser_label.Text = "2";
            // 
            // AngkatanUser_label
            // 
            this.AngkatanUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AngkatanUser_label.AutoSize = true;
            this.AngkatanUser_label.Location = new System.Drawing.Point(83, 64);
            this.AngkatanUser_label.Name = "AngkatanUser_label";
            this.AngkatanUser_label.Size = new System.Drawing.Size(197, 13);
            this.AngkatanUser_label.TabIndex = 7;
            this.AngkatanUser_label.Text = "2015";
            // 
            // Angkatan_label
            // 
            this.Angkatan_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Angkatan_label.AutoSize = true;
            this.Angkatan_label.Location = new System.Drawing.Point(4, 64);
            this.Angkatan_label.Name = "Angkatan_label";
            this.Angkatan_label.Size = new System.Drawing.Size(72, 13);
            this.Angkatan_label.TabIndex = 6;
            this.Angkatan_label.Text = "Angkatan ";
            // 
            // JurusanUser_label
            // 
            this.JurusanUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.JurusanUser_label.AutoSize = true;
            this.JurusanUser_label.Location = new System.Drawing.Point(83, 41);
            this.JurusanUser_label.Name = "JurusanUser_label";
            this.JurusanUser_label.Size = new System.Drawing.Size(197, 13);
            this.JurusanUser_label.TabIndex = 5;
            this.JurusanUser_label.Text = "Teknologi Informasi S1";
            // 
            // Jurusan_label
            // 
            this.Jurusan_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Jurusan_label.AutoSize = true;
            this.Jurusan_label.Location = new System.Drawing.Point(4, 41);
            this.Jurusan_label.Name = "Jurusan_label";
            this.Jurusan_label.Size = new System.Drawing.Size(72, 13);
            this.Jurusan_label.TabIndex = 4;
            this.Jurusan_label.Text = "Jurusan";
            // 
            // NimUser_label
            // 
            this.NimUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NimUser_label.AutoSize = true;
            this.NimUser_label.Location = new System.Drawing.Point(83, 22);
            this.NimUser_label.Name = "NimUser_label";
            this.NimUser_label.Size = new System.Drawing.Size(197, 13);
            this.NimUser_label.TabIndex = 3;
            this.NimUser_label.Text = "15/333333/TK/33333";
            // 
            // Nim_label
            // 
            this.Nim_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nim_label.AutoSize = true;
            this.Nim_label.Location = new System.Drawing.Point(4, 22);
            this.Nim_label.Name = "Nim_label";
            this.Nim_label.Size = new System.Drawing.Size(72, 13);
            this.Nim_label.TabIndex = 2;
            this.Nim_label.Text = "NIM";
            // 
            // NamaUser_label
            // 
            this.NamaUser_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NamaUser_label.AutoSize = true;
            this.NamaUser_label.Location = new System.Drawing.Point(83, 4);
            this.NamaUser_label.Name = "NamaUser_label";
            this.NamaUser_label.Size = new System.Drawing.Size(197, 13);
            this.NamaUser_label.TabIndex = 1;
            this.NamaUser_label.Text = "Ip Man";
            // 
            // Nama_label
            // 
            this.Nama_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Nama_label.AutoSize = true;
            this.Nama_label.Location = new System.Drawing.Point(4, 4);
            this.Nama_label.Name = "Nama_label";
            this.Nama_label.Size = new System.Drawing.Size(72, 13);
            this.Nama_label.TabIndex = 0;
            this.Nama_label.Text = "Nama : ";
            // 
            // Profile_Picture
            // 
            this.Profile_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile_Picture.Image = global::iPlanner.Properties.Resources.profil;
            this.Profile_Picture.Location = new System.Drawing.Point(4, 4);
            this.Profile_Picture.Name = "Profile_Picture";
            this.Profile_Picture.Size = new System.Drawing.Size(110, 133);
            this.Profile_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile_Picture.TabIndex = 3;
            this.Profile_Picture.TabStop = false;
            // 
            // ProfilPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.Profil_table);
            this.Name = "ProfilPengguna";
            this.Text = "ProfilPengguna";
            this.Profil_table.ResumeLayout(false);
            this.Button_table.ResumeLayout(false);
            this.Riwayat_table.ResumeLayout(false);
            this.Riwayat_table.PerformLayout();
            this.Biodata_table.ResumeLayout(false);
            this.Biodata_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Profil_table;
        private System.Windows.Forms.TableLayoutPanel Button_table;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TableLayoutPanel Riwayat_table;
        private System.Windows.Forms.Label NilaiIPK_label;
        private System.Windows.Forms.Label NilaiSKSTotal_label;
        private System.Windows.Forms.Label IpTerakhir_label;
        private System.Windows.Forms.Label SksTerakhir_label;
        private System.Windows.Forms.Label Ip_label;
        private System.Windows.Forms.Label Sks_label;
        private System.Windows.Forms.Label IPK_label;
        private System.Windows.Forms.Label SksTotal_label;
        private System.Windows.Forms.TableLayoutPanel Biodata_table;
        private System.Windows.Forms.Label Semester_label;
        private System.Windows.Forms.Label SemesterUser_label;
        private System.Windows.Forms.Label AngkatanUser_label;
        private System.Windows.Forms.Label Angkatan_label;
        private System.Windows.Forms.Label JurusanUser_label;
        private System.Windows.Forms.Label Jurusan_label;
        private System.Windows.Forms.Label NimUser_label;
        private System.Windows.Forms.Label Nim_label;
        private System.Windows.Forms.Label NamaUser_label;
        private System.Windows.Forms.Label Nama_label;
        private System.Windows.Forms.PictureBox Profile_Picture;
    }
}
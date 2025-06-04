namespace GUI_PolyCafe
{
    partial class FrmTheLuuDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtChuSoHuu = new System.Windows.Forms.TextBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTheLuuDong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLuuDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(209, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THẺ LỰU ĐỘNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(93, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chủ sở hữu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(93, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(215, 69);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(237, 20);
            this.txtMaThe.TabIndex = 4;
            this.txtMaThe.TextChanged += new System.EventHandler(this.txtMaThe_TextChanged);
            // 
            // txtChuSoHuu
            // 
            this.txtChuSoHuu.Location = new System.Drawing.Point(215, 112);
            this.txtChuSoHuu.Name = "txtChuSoHuu";
            this.txtChuSoHuu.Size = new System.Drawing.Size(237, 20);
            this.txtChuSoHuu.TabIndex = 5;
            this.txtChuSoHuu.TextChanged += new System.EventHandler(this.txtChuSoHuu_TextChanged);
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.AutoSize = true;
            this.chkHoatDong.Checked = true;
            this.chkHoatDong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHoatDong.Location = new System.Drawing.Point(215, 159);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(77, 17);
            this.chkHoatDong.TabIndex = 6;
            this.chkHoatDong.Text = "Hoạt động";
            this.chkHoatDong.UseVisualStyleBackColor = true;
            this.chkHoatDong.CheckedChanged += new System.EventHandler(this.chkHoatDong_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(96, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(205, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(309, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(413, 206);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(800, 305);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 11;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLamMoi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtMaThe);
            this.tabPage1.Controls.Add(this.txtChuSoHuu);
            this.tabPage1.Controls.Add(this.chkHoatDong);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cập nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTheLuuDong);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTheLuuDong
            // 
            this.dgvTheLuuDong.AllowUserToAddRows = false;
            this.dgvTheLuuDong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTheLuuDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheLuuDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTheLuuDong.ColumnHeadersHeight = 15;
            this.dgvTheLuuDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheLuuDong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTheLuuDong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTheLuuDong.Location = new System.Drawing.Point(6, 6);
            this.dgvTheLuuDong.Name = "dgvTheLuuDong";
            this.dgvTheLuuDong.ReadOnly = true;
            this.dgvTheLuuDong.RowHeadersVisible = false;
            this.dgvTheLuuDong.Size = new System.Drawing.Size(598, 283);
            this.dgvTheLuuDong.TabIndex = 0;
            this.dgvTheLuuDong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTheLuuDong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTheLuuDong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTheLuuDong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTheLuuDong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTheLuuDong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTheLuuDong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTheLuuDong.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvTheLuuDong.ThemeStyle.ReadOnly = true;
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTheLuuDong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTheLuuDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLuuDong_CellClick);
            // 
            // FrmTheLuuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "FrmTheLuuDong";
            this.Text = "FrmTheLuuDong";
            this.Load += new System.EventHandler(this.FrmTheLuuDong_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLuuDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtChuSoHuu;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTheLuuDong;
    }
}
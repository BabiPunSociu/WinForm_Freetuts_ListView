namespace CoBan_ListView
{
    partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhong = new System.Windows.Forms.TextBox();
			this.txtSoLuongNhanSu = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoaHet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(225, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm Phòng Ban Mới";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên phòng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(235, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số lượng nhân sự";
			// 
			// txtPhong
			// 
			this.txtPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhong.Location = new System.Drawing.Point(297, 73);
			this.txtPhong.Name = "txtPhong";
			this.txtPhong.Size = new System.Drawing.Size(449, 34);
			this.txtPhong.TabIndex = 3;
			// 
			// txtSoLuongNhanSu
			// 
			this.txtSoLuongNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuongNhanSu.Location = new System.Drawing.Point(297, 133);
			this.txtSoLuongNhanSu.Name = "txtSoLuongNhanSu";
			this.txtSoLuongNhanSu.Size = new System.Drawing.Size(449, 34);
			this.txtSoLuongNhanSu.TabIndex = 4;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.LightSalmon;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPhong,
            this.columnSoluong});
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(34, 190);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(711, 230);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnPhong
			// 
			this.columnPhong.Text = "Phòng";
			this.columnPhong.Width = 220;
			// 
			// columnSoluong
			// 
			this.columnSoluong.Text = "Số lượng";
			this.columnSoluong.Width = 104;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(36, 448);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(139, 42);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(232, 448);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(139, 42);
			this.btnXoa.TabIndex = 7;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(607, 448);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(139, 42);
			this.btnThoat.TabIndex = 8;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoaHet
			// 
			this.btnXoaHet.Location = new System.Drawing.Point(426, 448);
			this.btnXoaHet.Name = "btnXoaHet";
			this.btnXoaHet.Size = new System.Drawing.Size(139, 42);
			this.btnXoaHet.TabIndex = 9;
			this.btnXoaHet.Text = "Xóa hết";
			this.btnXoaHet.UseVisualStyleBackColor = true;
			this.btnXoaHet.Click += new System.EventHandler(this.btnXoaHet_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(800, 511);
			this.Controls.Add(this.btnXoaHet);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.txtSoLuongNhanSu);
			this.Controls.Add(this.txtPhong);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListView";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtSoLuongNhanSu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaHet;
        private System.Windows.Forms.ColumnHeader columnPhong;
        private System.Windows.Forms.ColumnHeader columnSoluong;
    }
}


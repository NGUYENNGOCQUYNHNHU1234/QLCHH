namespace QLCHH
{
    partial class KH
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMadonhang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dateNgaydathang = new System.Windows.Forms.DateTimePicker();
            this.cboMatrangthai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã đơn hàng";
            // 
            // txtMadonhang
            // 
            this.txtMadonhang.Location = new System.Drawing.Point(194, 75);
            this.txtMadonhang.Name = "txtMadonhang";
            this.txtMadonhang.Size = new System.Drawing.Size(252, 22);
            this.txtMadonhang.TabIndex = 5;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(194, 137);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(252, 22);
            this.txtMakhachhang.TabIndex = 7;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(224, 327);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(132, 36);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dateNgaydathang
            // 
            this.dateNgaydathang.Location = new System.Drawing.Point(194, 204);
            this.dateNgaydathang.Name = "dateNgaydathang";
            this.dateNgaydathang.Size = new System.Drawing.Size(252, 22);
            this.dateNgaydathang.TabIndex = 10;
            // 
            // cboMatrangthai
            // 
            this.cboMatrangthai.FormattingEnabled = true;
            this.cboMatrangthai.Location = new System.Drawing.Point(194, 265);
            this.cboMatrangthai.Name = "cboMatrangthai";
            this.cboMatrangthai.Size = new System.Drawing.Size(252, 23);
            this.cboMatrangthai.TabIndex = 11;
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 391);
            this.Controls.Add(this.cboMatrangthai);
            this.Controls.Add(this.dateNgaydathang);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtMakhachhang);
            this.Controls.Add(this.txtMadonhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KH";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.KH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMadonhang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DateTimePicker dateNgaydathang;
        private System.Windows.Forms.ComboBox cboMatrangthai;
    }
}
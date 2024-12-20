namespace QLCHH
{
    partial class QLDH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtdh = new System.Windows.Forms.DateTimePicker();
            this.cbtt = new System.Windows.Forms.ComboBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtmadh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rdmakh = new System.Windows.Forms.RadioButton();
            this.rdmadh = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvdanhsach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtdh);
            this.groupBox1.Controls.Add(this.cbtt);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.txtmadh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btLuu);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng:";
            // 
            // dtdh
            // 
            this.dtdh.Location = new System.Drawing.Point(150, 115);
            this.dtdh.Name = "dtdh";
            this.dtdh.Size = new System.Drawing.Size(352, 30);
            this.dtdh.TabIndex = 7;
            // 
            // cbtt
            // 
            this.cbtt.FormattingEnabled = true;
            this.cbtt.Location = new System.Drawing.Point(150, 152);
            this.cbtt.Name = "cbtt";
            this.cbtt.Size = new System.Drawing.Size(352, 30);
            this.cbtt.TabIndex = 6;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(150, 67);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(352, 30);
            this.txtmakh.TabIndex = 5;
            // 
            // txtmadh
            // 
            this.txtmadh.Location = new System.Drawing.Point(150, 22);
            this.txtmadh.Name = "txtmadh";
            this.txtmadh.ReadOnly = true;
            this.txtmadh.Size = new System.Drawing.Size(352, 30);
            this.txtmadh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã trạng thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày đặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(863, 137);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(85, 41);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(602, 137);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(85, 41);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(863, 29);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(85, 41);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(602, 29);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(85, 41);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTimkiem);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.rdmakh);
            this.groupBox2.Controls.Add(this.rdmadh);
            this.groupBox2.Location = new System.Drawing.Point(13, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm:";
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(404, 39);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(97, 41);
            this.btTimkiem.TabIndex = 3;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(167, 45);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(231, 30);
            this.txttimkiem.TabIndex = 2;
            // 
            // rdmakh
            // 
            this.rdmakh.AutoSize = true;
            this.rdmakh.Location = new System.Drawing.Point(7, 63);
            this.rdmakh.Name = "rdmakh";
            this.rdmakh.Size = new System.Drawing.Size(154, 26);
            this.rdmakh.TabIndex = 1;
            this.rdmakh.TabStop = true;
            this.rdmakh.Text = "Mã khách hàng:";
            this.rdmakh.UseVisualStyleBackColor = true;
            // 
            // rdmadh
            // 
            this.rdmadh.AutoSize = true;
            this.rdmadh.Location = new System.Drawing.Point(7, 30);
            this.rdmadh.Name = "rdmadh";
            this.rdmadh.Size = new System.Drawing.Size(139, 26);
            this.rdmadh.TabIndex = 0;
            this.rdmadh.TabStop = true;
            this.rdmadh.Text = "Mã đơn hàng:";
            this.rdmadh.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvdanhsach);
            this.groupBox3.Location = new System.Drawing.Point(13, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hiển thị:";
            // 
            // dtgvdanhsach
            // 
            this.dtgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdanhsach.Location = new System.Drawing.Point(7, 30);
            this.dtgvdanhsach.Name = "dtgvdanhsach";
            this.dtgvdanhsach.RowTemplate.Height = 24;
            this.dtgvdanhsach.Size = new System.Drawing.Size(975, 180);
            this.dtgvdanhsach.TabIndex = 0;
            this.dtgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdanhsach_CellClick);
            // 
            // QLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDH";
            this.Text = "QLDH";
            this.Load += new System.EventHandler(this.QLDH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvdanhsach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rdmakh;
        private System.Windows.Forms.RadioButton rdmadh;
        private System.Windows.Forms.DateTimePicker dtdh;
        private System.Windows.Forms.ComboBox cbtt;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtmadh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
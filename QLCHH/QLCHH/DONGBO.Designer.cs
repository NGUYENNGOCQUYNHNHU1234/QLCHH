namespace QLCHH
{
    partial class DONGBO
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
            this.dtgDongBo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDongBo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDongBo
            // 
            this.dtgDongBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDongBo.Location = new System.Drawing.Point(54, 164);
            this.dtgDongBo.Name = "dtgDongBo";
            this.dtgDongBo.RowTemplate.Height = 24;
            this.dtgDongBo.Size = new System.Drawing.Size(977, 150);
            this.dtgDongBo.TabIndex = 1;
            // 
            // DONGBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 471);
            this.Controls.Add(this.dtgDongBo);
            this.Name = "DONGBO";
            this.Text = "DONGBO";
            this.Load += new System.EventHandler(this.DONGBO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDongBo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDongBo;
    }
}
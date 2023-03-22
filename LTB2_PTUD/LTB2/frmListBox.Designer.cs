
namespace LTB2
{
    partial class frmListBox
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
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDanhSachChon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Trần Văn Nam",
            "Phạm Anh Quân",
            "Lê Tấn Đan Huy",
            "Đinh Lê Quang Huy",
            "Lê Ngọc Hoàng Chương",
            "Võ Xuân Quang"});
            this.lbDanhSach.Location = new System.Drawing.Point(12, 62);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(157, 147);
            this.lbDanhSach.TabIndex = 0;
            this.lbDanhSach.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sinh viên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(251, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.ForeColor = System.Drawing.Color.Red;
            this.lbDanhSachChon.FormattingEnabled = true;
            this.lbDanhSachChon.Location = new System.Drawing.Point(254, 62);
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.Size = new System.Drawing.Size(157, 147);
            this.lbDanhSachChon.TabIndex = 0;
            this.lbDanhSachChon.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(182, 74);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(59, 37);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(182, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 268);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Name = "frmListBox";
            this.Text = "ListBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDanhSachChon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
    }
}
namespace frmNhapLieu
{
    partial class frmNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSoDong = new Label();
            txtSoDong = new TextBox();
            lblSoCot = new Label();
            txtSoCot = new TextBox();
            btnKhoiTao = new Button();
            SuspendLayout();
            // 
            // lblSoDong
            // 
            lblSoDong.AutoSize = true;
            lblSoDong.Location = new Point(24, 19);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Size = new Size(51, 15);
            lblSoDong.TabIndex = 0;
            lblSoDong.Text = "Số dòng";
            // 
            // txtSoDong
            // 
            txtSoDong.Location = new Point(99, 11);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(100, 23);
            txtSoDong.TabIndex = 2;
            // 
            // lblSoCot
            // 
            lblSoCot.AutoSize = true;
            lblSoCot.Location = new Point(24, 54);
            lblSoCot.Name = "lblSoCot";
            lblSoCot.Size = new Size(40, 15);
            lblSoCot.TabIndex = 3;
            lblSoCot.Text = "Số cột";
            // 
            // txtSoCot
            // 
            txtSoCot.Location = new Point(99, 51);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(100, 23);
            txtSoCot.TabIndex = 4;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Location = new Point(218, 11);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(102, 58);
            btnKhoiTao.TabIndex = 5;
            btnKhoiTao.Text = "Khởi tạo";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.Click += this.btnKhoiTao_Click;
            // 
            // frmNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 105);
            Controls.Add(btnKhoiTao);
            Controls.Add(txtSoCot);
            Controls.Add(lblSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(lblSoDong);
            Name = "frmNhap";
            Text = "Nhập liệu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoDong;
        private TextBox txtSoDong;
        private Label lblSoCot;
        private TextBox txtSoCot;
        private Button btnKhoiTao;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmNhapLieu
{
    public partial class frmXuat : Form
    {
        private void frmXuat_Load(object sender, EventArgs e)
        {
        }
        // Property lưu số dòng và số cột
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        // Field lưu kích thước và khoảng cách
        int h = 35, margin = 5;

        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();

            SoDong = dong;
            SoCot = cot;

            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Button btn = new Button();

                    btn.Width = h;
                    btn.Height = h;

                    btn.Text = (i * SoCot + j + 1).ToString();

                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;

                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;

                    btn.Tag = string.Format(
                        "Dòng {0} cột {1}", i, j);

                    this.Controls.Add(btn);
                }
            }

            // Điều chỉnh kích thước vùng bên trong Form
            this.ClientSize = new Size(
                SoCot * (h + margin + 1),
                SoDong * (h + margin + 1));
        }

        private void HoChuotLenButton(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                this.Text = btn.Tag?.ToString() ?? "";
            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show(btn.Text);
            }
        }
    }
}

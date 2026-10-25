namespace frmNhapLieu
{
    public partial class frmNhap : Form
    {
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int sodong, socot;

            if (!int.TryParse(txtSoDong.Text, out sodong))
                sodong = 1;

            if (!int.TryParse(txtSoCot.Text, out socot))
                socot = 1;

            if (sodong <= 0 || socot <= 0)
            {
                MessageBox.Show("So dong va so cot phai lon hon 0.");
                return;
            }

            frmXuat frmX = new frmXuat(sodong, socot);

            frmX.StartPosition = FormStartPosition.CenterScreen;
            frmX.ShowDialog();
        }
        public frmNhap()
        {
            InitializeComponent();
        }
    }
}

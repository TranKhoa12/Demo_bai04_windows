using System;
using System.Windows.Forms;

namespace Demo_bai04_windows
{
    public partial class Form2 : Form
    {
        // 1. Khai báo delegate: chữ ký của phương thức nhận dữ liệu
        public delegate void GuiSinhVienHandler(object sender, SinhVienEventArgs e);

        // 2. Khai báo event dựa trên delegate (Form1 sẽ đăng ký lắng nghe)
        public event GuiSinhVienHandler GuiSinhVien;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                //MessageBox.Show("Vui lòng nhập tên sinh viên.");
                MessageBox.Show("Vui lòng nhập tên sinh viên.","Thông báo lỗi",
                    MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
                return;
            }
            double diem; // kiểm tra điểm có hợp lệ không

            if (!double.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("Điểm không hợp lệ.","Thông báo lỗi",
                    MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng SinhVien từ dữ liệu nhập vào
            SinhVien sv = new SinhVien { Ten = txtTen.Text.Trim(), Diem = diem };

            // 3. Kích hoạt event -> gọi các phương thức đã đăng ký (bên Form1)
            if (GuiSinhVien != null)
                GuiSinhVien(this, new SinhVienEventArgs(sv));

            this.Close(); // đóng Form2 sau khi gửi dữ liệu
        }


    }
}

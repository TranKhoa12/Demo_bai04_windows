using System;
using System.Windows.Forms;

namespace Demo_bai04_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // KHỞI TẠO VÀ GỌI FORM2


            // bước 1, 2 và bước 3 đã được thực hiện ở form 2,
            // bây giờ form 1 sẽ đăng ký lắng nghe sự kiện GuiSinhVien của form 2

            // 4. Đăng ký phương thức xử lý với event của Form2
            f2.GuiSinhVien += new Form2.GuiSinhVienHandler(NhanSinhVien);
            f2.ShowDialog();


        }

        // 5. Phương thức được gọi khi Form2 gửi dữ liệu
        private void NhanSinhVien(object sender, SinhVienEventArgs e)
        {
            lstSinhVien.Items.Add(e.SV);
            // nhận sinh viên từ form2 và hiển thị trên listbox lstSinhVien
        }
    }
}

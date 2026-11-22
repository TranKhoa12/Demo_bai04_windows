using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_bai04_windows
{
    public class SinhVien
    {
        public string Ten { get; set; }
        public double Diem { get; set; }

        public override string ToString()   // để ListBox hiển thị đẹp
        {
            return Ten + " - " + Diem; // NGUYEN VAN A - 10
        }

    }
    // Gói dữ liệu gửi kèm sự kiện (kế thừa EventArgs như slide 15)
    public class SinhVienEventArgs : EventArgs
    {
        public SinhVien SV { get; }
        public SinhVienEventArgs(SinhVien sv) { SV = sv; }
    }
}

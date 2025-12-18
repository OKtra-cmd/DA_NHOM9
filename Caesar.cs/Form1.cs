using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DemoCeasar
{
    public partial class Form1 : Form
    {
        private TroGiupCeasar troGiup;
        private List<string> danhSachGiaiMa = new List<string>();

        //Khởi tạo Form, cấu hình TextBox và nạp từ điển
        public Form1()
        {
            InitializeComponent();

            txtInput.Multiline = true;
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.MaxLength = int.MaxValue;

            txtOutput.Multiline = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.MaxLength = int.MaxValue;

            txtOutput.ReadOnly = true;


            troGiup = new TroGiupCeasar(lblBest);

            string duongDan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.txt");

            if (File.Exists(duongDan))
                troGiup.NapTuDien(duongDan);
            else
                troGiup.NapTuDienMacDinh();
        }

        //Nút Brute-force: thử tất cả khóa và chọn kết quả tốt nhất
        private void btnBrute_Click(object sender, EventArgs e)
        {
            string chuoiMa = "";
            if (txtInput.Text != null)
                chuoiMa = txtInput.Text.Trim();

            // Kiểm tra nếu người dùng chưa nhập gì hoặc vẫn là placeholder
            if (chuoiMa == "" || chuoiMa == "Nhập văn bản mã hóa tại đây xong bấm giải mã(Input)")
            {
                MessageBox.Show("Vui lòng nhập văn bản mã hóa.");
                return;
            }

            lstResults.Items.Clear();
            danhSachGiaiMa.Clear();

            List<(int Khoa, string GiaiMa, int Diem)> danhSach = new List<(int Khoa, string GiaiMa, int Diem)>();

            for (int k = 0; k < 26; k++)
            {
                string giai = troGiup.GiaiMaTheoKhoa(chuoiMa, k);
                int diem = troGiup.DemTuHopLe(giai);

                danhSach.Add((k, giai, diem));
                danhSachGiaiMa.Add(giai); // Lưu toàn bộ kết quả

                lstResults.Items.Add("Khóa "+k+" :" +giai.Substring(0, Math.Min(120, giai.Length))+"...");
            }

            int diemMax = -1;
            foreach ((int Khoa, string GiaiMa, int Diem) x in danhSach)
            {
                if (x.Diem > diemMax)
                    diemMax = x.Diem;
            }

            (int Khoa, string GiaiMa, int Diem) totNhat = (0, "", 0);

            foreach ((int Khoa, string GiaiMa, int Diem) x in danhSach)
            {
                if (x.Diem == diemMax)
                {
                    if (totNhat.GiaiMa == "" || troGiup.DemNguyenAm(x.GiaiMa) > troGiup.DemNguyenAm(totNhat.GiaiMa))
                    {
                        totNhat = x;
                    }
                }        
            }

            lblBest.Text = "Kết quả tốt nhất: Khoa " + totNhat.Khoa+ "(Điểm "+totNhat.Diem+")";

            txtOutput.Text = totNhat.GiaiMa;

            lstResults.SelectedIndex = totNhat.Khoa;
        }


        //Nút Tải từ điển
        private void btnNapTuDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                troGiup.NapTuDien(dlg.FileName);
                MessageBox.Show("Đã nạp từ điển thành công!");
            }
        }

        //Nút Lưu kết quả
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu.");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtOutput.Text);
                MessageBox.Show("Đã lưu!");
            }
        }

        //Nút Xóa kết quả
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            txtOutput.Text = "";
        }

        //Nút Hướng dẫn
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            menu.Items.Add("Cách tải từ điển", null, (s, ev) =>
            {
                MessageBox.Show("Hướng dẫn tải từ điển:\n1. Bấm nút 'Tải từ điển'\n2. Chọn file có đuôi .txt\n3. Nhấn OK để nạp.");
            });
            menu.Items.Add("Cách sử dụng phần mềm", null, (s, ev) =>
            {
                MessageBox.Show("Hướng dẫn sử dụng:\n1. Nhập văn bản mã hóa vào ô Input\n2. Bấm nút 'Giải mã'\n3. Xem kết quả tốt nhất trong ô Output.");
            });
            menu.Items.Add("Cách hoạt động của mã hóa Caesar", null, (s, ev) =>
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn mở trang giải thích về mã hóa Caesar không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://vi.wikipedia.org/wiki/M%E1%BA%ADt_m%C3%A3_Caesar");
                }
            });

            menu.Show(btnHuongDan, new Point(0, btnHuongDan.Height));
        }



        //Nút Thoát ứng dụng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        //Sự kiện chọn dòng trong ListBox: hiển thị kết quả vào ô Giải mã
        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstResults.SelectedIndex;
            if (index >= 0 && index < danhSachGiaiMa.Count)
            {
                txtOutput.Text = danhSachGiaiMa[index];
            }
        }
        //Thiết lập placeholder mặc định khi Form vừa mở
        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "Nhập văn bản mã hóa tại đây xong bấm giải mã(Input)";
            txtInput.ForeColor = Color.Gray;

            txtOutput.Text = "Kết quả giải mã sẽ hiển thị ở đây(Output)";
            txtOutput.ForeColor = Color.Black;
        }

        //Xóa placeholder khi người dùng bắt đầu nhập vào ô Input
        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text == "Nhập văn bản mã hóa tại đây xong bấm giải mã(Input)")
            {
                txtInput.Text = "";
                txtInput.ForeColor = Color.Black;
            }
        }

        //Nếu ô Input trống thì hiển thị lại placeholder
        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtInput.Text = "Nhập văn bản mã hóa tại đây xong bấm giải mã(Input)";
                txtInput.ForeColor = Color.Gray;
            }
        }

        //Xóa placeholder khi người dùng click vào ô Output
        private void txtOutput_Enter(object sender, EventArgs e)
        {
            if (txtOutput.Text == "Kết quả giải mã sẽ hiển thị ở đây(Output)")
            {
                txtOutput.Text = "";
                txtOutput.ForeColor = Color.Black;
            }
        }

        //Nếu ô Output trống thì hiển thị lại placeholder
        private void txtOutput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                txtOutput.Text = "Kết quả giải mã sẽ hiển thị ở đây(Output)";
                txtOutput.ForeColor = Color.Gray;
            }
        }
    }
}

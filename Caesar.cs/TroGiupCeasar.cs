using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoCeasar
{
    public class TroGiupCeasar
    {
        private HashSet<string> TuDien = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private Label lblBest;

        // Hàm khởi tạo: nhận vào Label để hiển thị trạng thái
        public TroGiupCeasar(Label lbl)
        {
            lblBest = lbl;
        }

        // Hàm DoiKyTu: dịch chuyển một ký tự theo thuật toán Caesar với khóa cho trước
        public char DoiKyTu(char kyTu, int khoa)
        {
            if (!char.IsLetter(kyTu)) return kyTu;
            char kyTuCoSo = char.IsUpper(kyTu) ? 'A' : 'a';
            int viTriGoc = kyTu - kyTuCoSo;
            int viTriMoi = (viTriGoc + khoa + 26) % 26;
            return (char)(kyTuCoSo + viTriMoi);
        }

        // Hàm GiaiMaTheoKhoa: giải mã chuỗi theo một khóa Caesar
        public string GiaiMaTheoKhoa(string chuoiMa, int khoa)
        {
            int khoaNguoc = (26 - (khoa % 26)) % 26;

            StringBuilder sb = new StringBuilder(chuoiMa.Length);

            foreach (char ch in chuoiMa)
                sb.Append(DoiKyTu(ch, khoaNguoc));

            return sb.ToString();
        }

        // Hàm NapTuDien: nạp từ điển từ file .txt
        public void NapTuDien(string duongDan)
        {
            TuDien.Clear();

            foreach (string dong in File.ReadAllLines(duongDan))
            {
                string clean = new string(dong.Where(char.IsLetter).ToArray()).ToLower();
                if (clean.Length > 0)
                    TuDien.Add(clean);
            }

            lblBest.Text = $"Đã nạp {TuDien.Count} từ từ điển";
        }

        // Hàm NapTuDienMacDinh: nạp một số từ mặc định nếu không có file từ điển
        public void NapTuDienMacDinh()
        {
            TuDien.Clear();

            string[] macDinh = {
                "meet","later","hello","world","test","good","night","morning"
            };

            foreach (string w in macDinh)
                TuDien.Add(w);

            lblBest.Text = $"Đã nạp mặc định {TuDien.Count} từ";
        }

        // Hàm DemTuHopLe: đếm số từ trong chuỗi có mặt trong từ điển
        public int DemTuHopLe(string chuoi)
        {
            if (TuDien.Count == 0) return 0;

            string[] tokens = chuoi
                .ToLower()
                .Split(new char[] { ' ', ',', '.', '?', '!', '\n', '\r', '\t' },
                       StringSplitOptions.RemoveEmptyEntries);

            int dem = 0;

            foreach (string t in tokens)
            {
                string clean = new string(t.Where(char.IsLetter).ToArray());
                if (clean.Length > 0 && TuDien.Contains(clean))
                    dem++;
            }

            return dem;
        }

        // Hàm DemNguyenAm: đếm số nguyên âm (a, e, i, o, u) trong chuỗi
        public int DemNguyenAm(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int dem = 0;

            foreach (char ch in s.ToLower())
                if ("aeiou".Contains(ch))
                    dem++;

            return dem;
        }
    }
}

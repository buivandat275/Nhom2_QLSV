using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_pro
{
    public partial class GhiDanhSv : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sqlda;

        public GhiDanhSv()
        {
            InitializeComponent();
        }
        // Hàm kết nối cơ sở dữ liệu
        public void ketnoi()
        {
            string ketnoi = "Data Source=DESKTOP-49O1M0L\\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True;";
            conn = new SqlConnection(ketnoi);
            conn.Open();
        }

        // Hàm hiển thị danh sách sinh viên
        private void HienThiSinhVien()
        {
            string sql = "SELECT * FROM SinhVien WHERE da_xoa = 0";
            sqlda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            sqlda.Fill(ds, "SinhVien");
            cbSinhVien.DataSource = ds.Tables["SinhVien"];
            cbSinhVien.DisplayMember = "ho_ten";
            cbSinhVien.ValueMember = "ma_sinh_vien";
        }

        // Hàm hiển thị danh sách lớp học
        private void HienThiLopHoc()
        {
            string sql = "SELECT * FROM LopHoc WHERE da_xoa = 0";
            sqlda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            sqlda.Fill(ds, "LopHoc");
            cbLopHoc.DataSource = ds.Tables["LopHoc"];
            cbLopHoc.DisplayMember = "ten_lop";
            cbLopHoc.ValueMember = "ma_lop_hoc";
        }
        // Hàm hiển thị danh sách ghi danh của sinh viên vào lớp học
        private void HienThiDanhSachGhiDanh()
        {
            string sql = "SELECT GhiDanh.ma_ghi_danh, SinhVien.ho_ten, LopHoc.ten_lop " +
                         "FROM GhiDanh " +
                         "JOIN SinhVien ON GhiDanh.ma_sinh_vien = SinhVien.ma_sinh_vien " +
                         "JOIN LopHoc ON GhiDanh.ma_lop_hoc = LopHoc.ma_lop_hoc " +
                         "WHERE GhiDanh.da_xoa = 0";
            sqlda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            sqlda.Fill(ds, "GhiDanh");
            dataGridView1.DataSource = ds.Tables["GhiDanh"];
        }
        private void btGhiDanh_Click(object sender, EventArgs e)
        {
            if (cbSinhVien.SelectedIndex == -1 || cbLopHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên và lớp học.");
                return;
            }

            int maSinhVien = (int)cbSinhVien.SelectedValue;
            int maLopHoc = (int)cbLopHoc.SelectedValue;

            // Kiểm tra xem sinh viên đã ghi danh lớp học này chưa
            string checkExistSql = "SELECT COUNT(*) FROM GhiDanh WHERE ma_sinh_vien = @maSinhVien AND ma_lop_hoc = @maLopHoc";
            SqlCommand cmdCheck = new SqlCommand(checkExistSql, conn);
            cmdCheck.Parameters.AddWithValue("@maSinhVien", maSinhVien);
            cmdCheck.Parameters.AddWithValue("@maLopHoc", maLopHoc);
            int count = (int)cmdCheck.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Sinh viên đã ghi danh vào lớp học này.");
                return;
            }

            // Thực hiện ghi danh sinh viên vào lớp học
            string sqlInsert = "INSERT INTO GhiDanh (ma_sinh_vien, ma_lop_hoc, so_buoi_nghi, da_xoa) VALUES (@maSinhVien, @maLopHoc, 0, 0)";
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.AddWithValue("@maSinhVien", maSinhVien);
            cmdInsert.Parameters.AddWithValue("@maLopHoc", maLopHoc);

            try
            {
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Ghi danh sinh viên thành công!");
                HienThiDanhSachGhiDanh(); // Cập nhật danh sách ghi danh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi danh: " + ex.Message);
            }
        }

        private void GhiDanhSv_Load(object sender, EventArgs e)
        {
            ketnoi();
            HienThiSinhVien();
            HienThiLopHoc();

        }
    }
}

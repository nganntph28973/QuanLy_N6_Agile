using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLy_N6_Agile.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLy_N6_Agile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        QL_N6_AgileContext db = new QL_N6_AgileContext();


        public void LoadData()
        {

            var resul = from gr in db.Grades
                        join st in db.Students on gr.Masv equals st.Masv
                        select
                        new
                        {
                            Student =

                            gr.Masv,
                            st.Hoten,
                            gr.Tienganh,
                            gr.Tinhoc,
                            gr.Gdtc,
                            Diemtrungbinh = (gr.Gdtc + gr.Tinhoc + gr.Tienganh) / 3
                        };
            dgv_ThongTin.DataSource = resul.OrderBy(x => x.Hoten).ToList();

            dgv_ThongTin.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_ThongTin.Columns[1].HeaderText = "Họ Tên";
            dgv_ThongTin.Columns[2].HeaderText = "Điểm Tiếng Anh";
            dgv_ThongTin.Columns[3].HeaderText = "Điểm Tin Học";
            dgv_ThongTin.Columns[4].HeaderText = "Điểm GDCD";
            dgv_ThongTin.Columns[5].HeaderText = "Điểm Trung Bình";

        }

        public List<Grade> FindByMaSV(string maSV)
        {
            return FindByMaSV(maSV);
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var result = FindByMaSV(txt_MaSv.Text).Select(x => x.ToString());

        }

        private void dgv_ThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_MaSv.Text = dgv_ThongTin.Rows[d].Cells[0].Value.ToString();
            txtTen.Text = dgv_ThongTin.Rows[d].Cells[1].Value.ToString();
            txtTiengAnh.Text = dgv_ThongTin.Rows[d].Cells[2].Value.ToString();
            txtTinHoc.Text = dgv_ThongTin.Rows[d].Cells[3].Value.ToString();
            txtGDTC.Text = dgv_ThongTin.Rows[d].Cells[4].Value.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txt_MaSv.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
               if (string.IsNullOrWhiteSpace(txtTiengAnh.Text))
                {
                    MessageBox.Show("Điểm Tiếng Anh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtTinHoc.Text))
                {
                    MessageBox.Show("Điểm Tin Học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtGDTC.Text))
                {
                    MessageBox.Show("Điểm Giáo Dục Công Dân không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string idSvSua = txt_MaSv.Text;
                    Grade SvSua = db.Grades.Find(idSvSua);
                    if (SvSua != null)
                    {

                        SvSua.Tienganh = Convert.ToDouble(txtTiengAnh.Text);
                        SvSua.Tinhoc = Convert.ToDouble(txtTinHoc.Text);
                        SvSua.Gdtc = Convert.ToDouble(txtGDTC.Text);
                        db.SaveChanges();
                    }

                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_MaSv.Text = "";
            txtTen.Text = "";
            txtTiengAnh.Text = "";
            txtTinHoc.Text = "";
            txtGDTC.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }


}


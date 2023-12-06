using QuanLy_N6_Agile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_N6_Agile
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        QL_N6_AgileContext db = new QL_N6_AgileContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            LOADDATA();
        }
        public void LOADDATA()
        {
            var resul = from sv in db.Students
                        select
                        new
                        {
                            ID = sv.Masv,
                            sv.Hoten,
                            sv.Email,
                            sv.SoDt,
                            sv.Gioitinh,
                            sv.DiaChi
                        };
            dgv_ThongTinSV.DataSource = resul.OrderBy(x => x.Hoten).ToList();
            dgv_ThongTinSV.Columns[0].HeaderText = "Mã Sinh Viên";
            dgv_ThongTinSV.Columns[1].HeaderText = "Họ Tên";
            dgv_ThongTinSV.Columns[2].HeaderText = "Email";
            dgv_ThongTinSV.Columns[3].HeaderText = "Số Điện Thoại";
            dgv_ThongTinSV.Columns[4].HeaderText = "Giới Tính";
            dgv_ThongTinSV.Columns[5].HeaderText = "Địa Chỉ";
        }

        private void dgv_ThongTinSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_MaSV.Text = dgv_ThongTinSV.Rows[d].Cells[0].Value.ToString();
            txt_Ten.Text = dgv_ThongTinSV.Rows[d].Cells[1].Value.ToString();
            txt_email.Text = dgv_ThongTinSV.Rows[d].Cells[2].Value.ToString();
            txt_SDT.Text = dgv_ThongTinSV.Rows[d].Cells[3].Value.ToString();

            txt_DiaChi.Text = dgv_ThongTinSV.Rows[d].Cells[5].Value.ToString();
            if (dgv_ThongTinSV.Rows[d].Cells[4].Value.ToString().Equals("Nam"))
                rbn_Nam.Checked = true;
            else
                rbn_Nu.Checked = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_MaSV.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_email.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_SDT.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //check id xem ton tai hay chua
                    Student stdThem = db.Students.Where(nv => nv.Masv.Equals(txt_MaSV.Text)).SingleOrDefault();
                    if (stdThem != null)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string gt = "";
                        if (rbn_Nam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        Student std = new Student()
                        {
                            Masv = txt_MaSV.Text,
                            Hoten = txt_Ten.Text,
                            Email = txt_email.Text,
                            SoDt = txt_SDT.Text,
                            Gioitinh = gt,
                            DiaChi = txt_DiaChi.Text
                        };
                        db.Students.Add(std);
                        db.SaveChanges();

                    }
                }
                LOADDATA();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_MaSV.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Ten.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_email.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_SDT.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string idsvSua = txt_MaSV.Text;
                    Student svSua = db.Students.Find(idsvSua);
                    if (svSua != null)
                    {
                        svSua.Hoten = txt_Ten.Text;
                        svSua.DiaChi = txt_DiaChi.Text;
                        svSua.Email = txt_email.Text;
                        svSua.SoDt = txt_SDT.Text;
                        if (rbn_Nam.Checked == true)
                        {
                            svSua.Gioitinh = "Nam";
                        }
                        else
                            svSua.Gioitinh = "Nữ";

                        db.SaveChanges();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LOADDATA();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string idSvXoa = txt_MaSV.Text;
            Student svXoa = db.Students.Find(idSvXoa);
            if (svXoa != null)
            {
                DialogResult re = MessageBox.Show("Ban co chac chan muon xoa", "Canh Bao", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    db.Students.Remove(svXoa);
                    db.SaveChanges();
                }
            }
            LOADDATA();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaSV.Text = "";
            txt_email.Text = "";
            txt_DiaChi.Text = "";
            txt_Ten.Text = "";
            txt_SDT.Text = "";
            rbn_Nu.Checked = false;
            rbn_Nam.Checked = false;
        }

        private void btn_Thoatt_Click(object sender, EventArgs e)
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


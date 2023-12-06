using System;
using System.Collections.Generic;

namespace QuanLy_N6_Agile.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
        }

        public string Masv { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public string? Email { get; set; }
        public string? SoDt { get; set; }
        public string? Gioitinh { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}

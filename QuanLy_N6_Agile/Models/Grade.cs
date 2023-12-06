using System;
using System.Collections.Generic;

namespace QuanLy_N6_Agile.Models
{
    public partial class Grade
    {
        public int Id { get; set; }
        public string Masv { get; set; } = null!;
        public double? Tienganh { get; set; }
        public double? Tinhoc { get; set; }
        public double? Gdtc { get; set; }

        public virtual Student MasvNavigation { get; set; } = null!;
    }
}

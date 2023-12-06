using System;
using System.Collections.Generic;

namespace QuanLy_N6_Agile.Models
{
    public partial class User
    {
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}

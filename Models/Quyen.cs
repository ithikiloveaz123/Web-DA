using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class Quyen
{
    public string Idquyen { get; set; } = null!;

    public string TenQuyen { get; set; } = null!;

    public virtual ICollection<DanhSachQuyen> DanhSachQuyens { get; set; } = new List<DanhSachQuyen>();
}

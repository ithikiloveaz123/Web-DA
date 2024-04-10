using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class PhanHoi
{
    public int Id { get; set; }

    public string HoTen { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string NoiDung { get; set; } = null!;

    public DateOnly NgayGui { get; set; }

    public bool TinhTrang { get; set; }
}

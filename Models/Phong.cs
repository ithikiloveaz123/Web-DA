using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class Phong
{
    public string MaP { get; set; } = null!;

    public string MaLp { get; set; } = null!;

    public string TinhTrang { get; set; } = null!;

    public virtual ICollection<CtphieuDatPhong> CtphieuDatPhongs { get; set; } = new List<CtphieuDatPhong>();

    public virtual ICollection<CtphieuThuePhong> CtphieuThuePhongs { get; set; } = new List<CtphieuThuePhong>();

    public virtual LoaiPhong MaLpNavigation { get; set; } = null!;
}

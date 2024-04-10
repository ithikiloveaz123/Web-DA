using System;
using System.Collections.Generic;

namespace Web_DA.Models;

public partial class CtphieuDatPhong
{
    public string MaPdp { get; set; } = null!;

    public string MaP { get; set; } = null!;

    public decimal TienCoc { get; set; }

    public virtual Phong MaPNavigation { get; set; } = null!;

    public virtual PhieuDatPhong MaPdpNavigation { get; set; } = null!;
}

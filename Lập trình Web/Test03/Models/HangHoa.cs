using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test03.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }

    public int MaLoai { get; set; }

    public string TenHang { get; set; } = null!;

    //[Required(ErrorMessage = "Price is required")]
    //[Range(100, 5000, ErrorMessage = "Price must be between 100 and 5000")]
    public decimal? Gia { get; set; }
    //[Required(ErrorMessage = "Image file is required")]
    //[RegularExpression(@"^.+\.(jpg|png|gif|tiff)$", ErrorMessage = "Invalid file format. Supported formats: jpg, png, gif, tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang? MaLoaiNavigation { get; set; } = null!;
}

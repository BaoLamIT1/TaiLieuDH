using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Student
    {
        /*        public int Id { get; set; }//Mã sinh viên
                public string? Name { get; set; } //Họ tên
                public string? Email { get; set; } //Email
                public string? Password { get; set; }//Mật khẩu
                public Branch? Branch { get; set; }//Ngành học
                public Gender? Gender { get; set; }//Giới tính
                public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq
                public string? Address { get; set; }//Địa chỉ
                public DateTime DateOfBorth { get; set; }//Ngày sinh
        */
                [FileExtensions(Extensions = "png,jpg,jpeg,gif")]
                public IFormFile? ImageURL { get; set; }
                public string ImagePath { get; set; }


        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage ="Phai nhap ten")]
        [StringLength(100,MinimumLength =4)]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com", ErrorMessage = "Email phải có gmail.com")]
        public string? Email { get; set; } //Email

        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Required]
        public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
    }
}

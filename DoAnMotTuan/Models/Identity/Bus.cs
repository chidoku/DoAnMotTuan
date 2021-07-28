using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnMotTuan.Models.Identity
{
    public class Bus
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Không được để trống")]
        [Display(Name ="Trạm đi")]
        public string BenXeA { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Trạm đến")]
        public string BenXeB { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Giờ đi")]
        public string ThoiGianA { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Giờ đến")]
        public string ThoiGianB { get; set; }

    }
}
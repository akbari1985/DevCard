using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(2,ErrorMessage ="حداقل طول این فیلد 2 کاراکتر است")]
        [MaxLength(100,ErrorMessage ="حداکثر طول این فیلد 100 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="آدرس ایمیل را درست وارد نمایید")]
        public string Email { get; set; }

        public string Message { get; set; }

        public string Service { get; set; }
    }
}

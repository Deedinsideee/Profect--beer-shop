using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PIVANDEPOLA.Data.Models
{
    public class Order
    {
        [BindNever]
        
        public int id { get; set; }

        [Display(Name ="Введите имя " )]
        [StringLength(10)]
        [Required(ErrorMessage ="Длина имени не менее 5 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию ")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес ")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите номер телефона ")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина номера не менее 5 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите email ")]
        [DataType(DataType.EmailAddress)]

        [Required(ErrorMessage = "Длина email не менее 5 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OderDetails> oderDetails { get; set; }
    }
}
 
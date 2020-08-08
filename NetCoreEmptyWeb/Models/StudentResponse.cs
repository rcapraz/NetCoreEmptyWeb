using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEmptyWeb.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage ="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        [EmailAddress(ErrorMessage ="Mail Adresiniz Uygun Değildir.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon No Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma Durumunuzu Bildiriniz")]
        public bool? Confirm { get; set; }//true,false eğer null ise confirm = null gelir 
    }
}

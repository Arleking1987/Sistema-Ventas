using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Ventas.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public int Name { get; set; }
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public int LastName { get; set; }
        [Required(ErrorMessage = "El campo nid es obligatorio")]
        public int NID { get; set; }
        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "El formato teléfono no es válido")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "El campo correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El campo correo electrónico no es una dirección de correo electrónico válido")]
        public int Email { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo contraseña es obligatorio")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}", MinimumLength = 6)]
        public int Password { get; set; }
    }
}

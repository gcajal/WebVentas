using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebVentas.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage ="El campo nombre es obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-.]?([0-9]{2})[-.]?([0-9]{5})$",ErrorMessage ="Formato invalido")]
        public string PhoneNumber { get; set; }
    }
}

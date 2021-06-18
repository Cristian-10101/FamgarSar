using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamgarSar.Models
{
    public class AcosoLaboral
    {
        [Key]
        public int AcosoLaboralId { get; set; }

        
        [Display(Name = "Fecha Diligenciamiento")]
       
        public DateTime FechaDiligencionamiento { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        [Display(Name = "Nombre")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        [Display(Name = "Documento de Identidad")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Document { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        [Display(Name = "C.C")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string ConCopia { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio, Ingrese un numero de Teléfono.")]
        [Display(Name = "Número")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string NumberTel { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        [Display(Name = "Dependencia")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Dependence { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio.")]
        [Display(Name = "Cargo")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string  Position { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio, Ingrese su correo electronico.")]
        [Display(Name = "Correo Electrónico")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este Campo es obligatorio, Ingrese su correo electronico.")]
        [StringLength(200, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "Debe tener mas de tres caracteres.")]
        public string Quejas { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Parcial2MVC.Models
{
    public class departamento
    {
        [Key]
        [Display(Name = "ID")]
        public int id_departamento { get; set; }
        [Display(Name = "Nombre del departamento")]
        public string? nombre_departamento { get; set; }
    }
}

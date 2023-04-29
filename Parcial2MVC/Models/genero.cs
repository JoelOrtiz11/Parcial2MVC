using System.ComponentModel.DataAnnotations;
namespace Parcial2MVC.Models
{
    public class genero
    {
        [Key]

        public int id_genero { get; set; }
        public string? tipo_genero { get; set; }
        public int? casos_confirmados { get; set; }
        public int? casos_recuperados { get; set; }
        public int? casos_fallecidos { get; set; }
        public int? id_departamento { get; set; }

    }
}

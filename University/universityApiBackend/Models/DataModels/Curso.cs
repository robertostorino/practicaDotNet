using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        public enum Nivels
        {
            Básico,
            Intermedio,
            Avanzado
        }
        
        
        
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;

        [Required]
        public string DescripcionLarga { get; set; } = string.Empty;

        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required]
        public string Objetivos { get; set; } = string.Empty;

        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public Nivels Nivel { get; set; }


    }
}

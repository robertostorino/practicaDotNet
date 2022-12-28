using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class User: BaseEntity
    {
        // Required: campo obligatorio
        // StringLenght: Tamaño màximo del string

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        // EmailAddress: verifica que el campo cumpla todos los requisitos de correo
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

    }
}

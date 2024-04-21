using System.ComponentModel.DataAnnotations;

namespace NewProject.Models
{
    /// <summary>
    /// Model danych użytkownika.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unikalny identyfikator użytkownika.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nazwa użytkownika.
        /// </summary>
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nazwa użytkownika musi zawierać od 3 do 50 znaków")]
        public string? Username { get; set; }

        /// <summary>
        /// Hasło użytkownika.
        /// </summary>
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Hasło musi zawierać co najmniej 6 znaków")]
        public string? Password { get; set; }

        /// <summary>
        /// Rola użytkownika.
        /// </summary>
        [Required(ErrorMessage = "Rola jest wymagana")]
        public string? Role { get; set; }
    }
}

namespace NewProject.Models
{
    /// <summary>
    /// Model danych do uwierzytelniania użytkownika.
    /// </summary>
    public class UserLoginDto
    {
        /// <summary>
        /// Pobiera lub ustawia nazwę użytkownika.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Pobiera lub ustawia hasło użytkownika.
        /// </summary>
        public string? Password { get; set; }
    }
}


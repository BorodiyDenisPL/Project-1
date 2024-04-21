namespace NewProject.Models
{
    /// <summary>
    /// Model danych do rejestracji nowego użytkownika.
    /// </summary>
    public class UserRegisterDto
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

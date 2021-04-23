using System.ComponentModel.DataAnnotations;

namespace TypingDashboard.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
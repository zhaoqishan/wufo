using System.ComponentModel.DataAnnotations;

namespace fuwo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
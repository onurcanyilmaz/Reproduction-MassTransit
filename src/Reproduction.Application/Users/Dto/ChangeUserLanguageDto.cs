using System.ComponentModel.DataAnnotations;

namespace Reproduction.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
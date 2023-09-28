using System.ComponentModel.DataAnnotations;

namespace MusicPortal.BLL.DTO
{
    public class StyleDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле является обязательным!")]
        [Display(Name = "Название")]
        public string? Name { get; set; }
    }
}

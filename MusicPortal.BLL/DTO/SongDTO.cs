using System.ComponentModel.DataAnnotations;

namespace MusicPortal.BLL.DTO
{
    public class SongDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле является обязательным!")]
        [Display(Name = "Название")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Поле является обязательным!")]
        [Display(Name = "Альбом")]
        public string? Album { get; set; }

        [Required(ErrorMessage = "Поле является обязательным!")]
        [Display(Name = "Год выпуска")]
        public int? ReleaseYear { get; set; }

        [Required(ErrorMessage = "Поле является обязательным!")]
        public string? Video { get; set; }

        public string Publisher { get; set; }

        public int StyleId { get; set; }
        [Display(Name = "Стиль")]
        public string Style { get; set; }

        public int SingerId { get; set; }
        [Display(Name = "Исполнитель")]
        public string Singer { get; set; }

    }
}

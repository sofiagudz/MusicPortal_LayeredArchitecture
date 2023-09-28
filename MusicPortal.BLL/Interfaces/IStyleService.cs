using MusicPortal.BLL.DTO;

namespace MusicPortal.BLL.Interfaces
{
    public interface IStyleService
    {
        Task AddStyle(StyleDTO styleDTO);
        Task EditStyle(StyleDTO styleDTO);
        Task DeleteStyle(int id);
        Task<StyleDTO> GetStyleById(int id);
        Task<IEnumerable<StyleDTO>> GetStyles();
    }
}

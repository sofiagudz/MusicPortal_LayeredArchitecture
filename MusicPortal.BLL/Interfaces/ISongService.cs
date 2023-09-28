using MusicPortal.BLL.DTO;

namespace MusicPortal.BLL.Interfaces
{
    public interface ISongService
    {
        Task AddSong(SongDTO songDTO);
        Task EditSong(SongDTO songDTO);
        Task DeleteSong(int id);
        Task<SongDTO> GetSongById(int id);
        Task<IEnumerable<SongDTO>> GetSongs();
    }
}

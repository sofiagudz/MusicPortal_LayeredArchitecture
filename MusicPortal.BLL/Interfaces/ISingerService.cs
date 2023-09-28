using MusicPortal.BLL.DTO;

namespace MusicPortal.BLL.Interfaces
{
    public interface ISingerService
    {
        Task AddSinger(SingerDTO singerDTO);
        Task EditSinger(SingerDTO singerDTO);
        Task DeleteSinger(int id);  
        Task<SingerDTO> GetSinger(int id);
        Task<IEnumerable<SingerDTO>> GetSingers(); 
    }
}

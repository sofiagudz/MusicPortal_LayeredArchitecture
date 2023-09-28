using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.Entities;
using MusicPortal.BLL.Infrastructure;
using AutoMapper;

namespace MusicPortal.BLL.Services
{
    public class SongService : ISongService
    {
        IUnitOfWork Database { get; set; }

        public SongService(IUnitOfWork database)
        {
            Database = database;
        }

        public async Task AddSong(SongDTO songDTO)
        {
            var song = new Song
            {
                Id = songDTO.Id,
                Name = songDTO.Name,
                Album = songDTO.Album,
                ReleaseYear = songDTO.ReleaseYear,
                Video = songDTO.Video,
                StyleId = songDTO.StyleId,
                SingerId = songDTO.SingerId
            };
            await Database.Songs.Add(song);
            await Database.Save();
        }

        public async Task EditSong(SongDTO songDTO)
        {
            var song = new Song
            {
                Id = songDTO.Id,
                Name = songDTO.Name,
                Album = songDTO.Album,
                ReleaseYear = songDTO.ReleaseYear,
                Video = songDTO.Video,
                StyleId = songDTO.StyleId,
                SingerId = songDTO.SingerId
            };
            Database.Songs.Update(song);
            await Database.Save();
        }

        public async Task DeleteSong(int id)
        {
            await Database.Songs.Delete(id);
            await Database.Save();
        }

        public async Task<SongDTO> GetSongById(int id)
        {
            var song = await Database.Songs.FindById(id);
            if(song == null)
            {
                throw new ValidationException("Wrong song!!!", "");
            }
            return new SongDTO
            {
                Id = song.Id,
                Name = song.Name,
                Album = song.Album,
                ReleaseYear = song.ReleaseYear,
                Video = song.Video,
                StyleId = song.StyleId,
                Style = song.Style.Name,
                SingerId = song.SingerId,
                Singer = song.Singer.Name
            };
        }

        public async Task<IEnumerable<SongDTO>> GetSongs()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Song, SongDTO>()
            .ForMember("Style", opt => opt.MapFrom(c => c.Style.Name))
            .ForMember("Singer", opt => opt.MapFrom(c => c.Singer.Name)));
            var mapper = new Mapper(config);
            return mapper.Map<IEnumerable<Song>, IEnumerable<SongDTO>>(await Database.Songs.ToList());
        }
    }
}

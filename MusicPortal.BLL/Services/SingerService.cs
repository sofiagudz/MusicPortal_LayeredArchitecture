using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.Entities;
using MusicPortal.BLL.Infrastructure;
using AutoMapper;

namespace MusicPortal.BLL.Services
{
    public class SingerService : ISingerService
    {
        IUnitOfWork Database { get; set; }

        public SingerService(IUnitOfWork database)
        {
            Database = database;
        }

        public async Task AddSinger(SingerDTO singerDTO)
        {
            var singer = new Singer
            {
                Id = singerDTO.Id,
                Name = singerDTO.Name
            };
            await Database.Singers.Add(singer);
            await Database.Save();
        }

        public async Task EditSinger(SingerDTO singerDTO)
        {
            var singer = new Singer
            {
                Id = singerDTO.Id,
                Name = singerDTO.Name
            };
            Database.Singers.Update(singer);
            await Database.Save();
        }

        public async Task DeleteSinger(int id)
        {
            await Database.Singers.Delete(id);
            await Database.Save();
        }

        public async Task<SingerDTO> GetSinger(int id)
        {
            var singer = await Database.Singers.FindById(id);
            if(singer == null)
            {
                throw new ValidationException("Wrong singer!!!", "");
            }
            return new SingerDTO
            {
                Id = singer.Id,
                Name = singer.Name
            };
        }

        public async Task<IEnumerable<SingerDTO>> GetSingers()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Singer, SingerDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Singer>, IEnumerable<SingerDTO>>(await Database.Singers.ToList());
        }
    }
}

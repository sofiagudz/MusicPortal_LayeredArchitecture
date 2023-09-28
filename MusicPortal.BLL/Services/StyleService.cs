using MusicPortal.BLL.DTO;
using MusicPortal.BLL.Interfaces;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.Entities;
using MusicPortal.BLL.Infrastructure;
using AutoMapper;

namespace MusicPortal.BLL.Services
{
    public class StyleService : IStyleService
    {
        IUnitOfWork Database { get; set; }

        public StyleService(IUnitOfWork database)
        {
            Database = database;
        }

        public async Task AddStyle(StyleDTO styleDTO)
        {
            var style = new Style
            {
                Id = styleDTO.Id,
                Name = styleDTO.Name
            };
            await Database.Styles.Add(style);
            await Database.Save();
        }

        public async Task EditStyle(StyleDTO styleDTO)
        {
            var style = new Style
            {
                Id = styleDTO.Id,
                Name = styleDTO.Name
            };
            Database.Styles.Update(style);
            await Database.Save();
        }

        public async Task DeleteStyle(int id)
        {
            await Database.Styles.Delete(id);
            await Database.Save();
        }

        public async Task<StyleDTO> GetStyleById(int id)
        {
            var style = await Database.Styles.FindById(id);
            if (style == null)
            {
                throw new ValidationException("Wrong style!!!", "");
            }
            return new StyleDTO
            {
                Id =style.Id,
                Name = style.Name
            };
        }

        public async Task<IEnumerable<StyleDTO>> GetStyles()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Style, StyleDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Style>, IEnumerable<StyleDTO>>(await Database.Styles.ToList());
        }
    }
}

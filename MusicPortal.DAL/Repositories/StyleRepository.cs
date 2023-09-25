using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;

namespace MusicPortal.DAL.Repositories
{
    public class StyleRepository : IRepository<Style>
    {
        private MusicPortalContext context;

        public StyleRepository(MusicPortalContext db)
        {
            context = db;
        }

        public async Task<List<Style>> ToList()
        {
            return await context.Styles.ToListAsync();
        }

        public async Task<IEnumerable<Style>> ToListIEnumerable()
        {
            return await context.Styles.ToListAsync();
        }

        public async Task Add(Style item)
        {
            await context.Styles.AddAsync(item);
        }

        public async Task<Style> FindById(int id)
        {
            return await context.Styles.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Update(Style item)
        {
            context.Update(item);
        }

        public async Task Delete(int id)
        {
            Style? c = await context.Styles.FindAsync(id);
            if (c != null)
                context.Styles.Remove(c);
        }
    }
}

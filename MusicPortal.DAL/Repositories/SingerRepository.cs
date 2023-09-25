using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;

namespace MusicPortal.DAL.Repositories
{
    public class SingerRepository : IRepository<Singer>
    {
        private MusicPortalContext context;

        public SingerRepository(MusicPortalContext db)
        {
            context = db;
        }

        public async Task<List<Singer>> ToList()
        {
            return await context.Singers.ToListAsync();
        }

        public async Task<IEnumerable<Singer>> ToListIEnumerable()
        {
            return await context.Singers.ToListAsync();
        }

        public async Task Add(Singer item)
        {
            await context.Singers.AddAsync(item);
        }

        public async Task<Singer> FindById(int id)
        {
            return await context.Singers.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Update(Singer item)
        {
            context.Update(item);
        }

        public async Task Delete(int id)
        {
            Singer? c = await context.Singers.FindAsync(id);
            if (c != null)
                context.Singers.Remove(c);
        }
    }
}

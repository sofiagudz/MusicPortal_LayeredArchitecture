using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;

namespace MusicPortal.DAL.Repositories
{
    public class SongRepository : IRepository<Song>
    {
        private MusicPortalContext context;

        public SongRepository(MusicPortalContext db)
        {
            context = db;
        }

        public async Task<List<Song>> ToList()
        {
            return await context.Songs.ToListAsync();
        }

        public async Task<IEnumerable<Song>> ToListIEnumerable()
        {
            return await context.Songs.ToListAsync();
        }

        public async Task Add(Song item)
        {
            await context.Songs.AddAsync(item);
        }

        public async Task<Song> FindById(int id)
        {
            return await context.Songs.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Update(Song item)
        {
            context.Update(item);
        }

        public async Task Delete(int id)
        {
            Song? c = await context.Songs.FindAsync(id);
            if (c != null)
                context.Songs.Remove(c);
        }
    }
}

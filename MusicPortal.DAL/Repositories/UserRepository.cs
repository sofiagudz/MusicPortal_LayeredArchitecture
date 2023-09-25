using Microsoft.EntityFrameworkCore;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;

namespace MusicPortal.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private MusicPortalContext context;

        public UserRepository(MusicPortalContext db)
        {
            context = db;
        }

        public async Task<List<User>> ToList()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> ToListIEnumerable()
        {
            return await context.Users.ToListAsync();
        }

        public async Task Add(User item)
        {
            await context.Users.AddAsync(item);
        }

        public async Task<User> FindById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(a => a.Id == id);
        }

        public void Update(User item)
        {
            context.Update(item);
        }

        public async Task Delete(int id)
        {
            User? c = await context.Users.FindAsync(id);
            if (c != null)
                context.Users.Remove(c);
        }
    }
}

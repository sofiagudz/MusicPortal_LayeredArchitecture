using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using MusicPortal.DAL.EF;

namespace MusicPortal.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private MusicPortalContext context;

        private UserRepository userRepository;
        private SongRepository songRepository;
        private StyleRepository styleRepository;
        private SingerRepository singerRepository;

        public EFUnitOfWork(MusicPortalContext context)
        {
            this.context = context;
        }

        public IRepository<User> Users
        {
            get
            {
                if(userRepository == null)
                {
                    userRepository = new UserRepository(context);
                }
                return userRepository;
            }
        }

        public IRepository<Song> Songs
        {
            get
            {
                if (songRepository == null)
                {
                    songRepository = new SongRepository(context);
                }
                return songRepository;
            }
        }

        public IRepository<Style> Styles
        {
            get
            {
                if (styleRepository == null)
                {
                    styleRepository = new StyleRepository(context);
                }
                return styleRepository;
            }
        }

        public IRepository<Singer> Singers
        {
            get
            {
                if (singerRepository == null)
                {
                    singerRepository = new SingerRepository(context);
                }
                return singerRepository;
            }
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}

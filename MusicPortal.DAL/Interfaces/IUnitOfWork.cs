using System;
using System.Collections.Generic;
using System.Linq;
using MusicPortal.DAL.Entities;

namespace MusicPortal.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Song> Songs { get; }
        IRepository<Style> Styles { get; }
        IRepository<Singer> Singers { get; }
        Task Save();
    }
}

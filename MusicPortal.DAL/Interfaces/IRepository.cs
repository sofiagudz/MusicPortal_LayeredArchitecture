using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPortal.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> ToList();
        Task<IEnumerable<T>> ToListIEnumerable();
        Task Add(T item);
        Task<T> FindById(int id);
        void Update(T item);
        Task Delete(int id);
    }
}

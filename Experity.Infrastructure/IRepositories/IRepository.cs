using Experity.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.IRepository
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> AddAsync(T entity);
        void Add(T entity);
        void Update(T entity);
        Task<T> GetByIdAsync(object id);
        T GetById(object id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        IEnumerable<T> GetAll();
    }
}

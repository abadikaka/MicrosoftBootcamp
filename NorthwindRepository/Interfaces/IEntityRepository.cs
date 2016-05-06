using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NorthwindRepository.Interfaces;
using System.Data.Entity.Core.Objects;
using DAL;

namespace NorthwindRepository.Interfaces
{
    public interface IEntityRepository<T, P> where T:class where P:IConvertible
    {
        IQueryable<T> GetAllData();

        T Search(P id);

        void Insert(T entity);

        void Delete(P id);

        void Update(T entity);
    }
}

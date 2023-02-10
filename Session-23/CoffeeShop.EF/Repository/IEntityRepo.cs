using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repository
{
    internal interface IEntityRepo<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id ,TEntity entity);

    }
}

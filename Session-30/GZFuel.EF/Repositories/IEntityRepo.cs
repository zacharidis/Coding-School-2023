using GZFuel.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Repositories
{
    public interface IEntityRepo<TEntity>

    {
        // CRUD operations
        IList<TEntity> GetAll();
        
        TEntity? GetById(int id);

        void Add (TEntity entity);

        void Update(int id, TEntity entity);

        void Delete(int id);

    }

        
    
    }


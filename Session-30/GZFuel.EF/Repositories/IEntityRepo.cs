using GZFuel.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.EF.Repositories
{
    public interface IEntityRepo<TEntity>
    


        where TEntity : BaseEntity {
        // CRUD operations
        // Create
        void Add(TEntity entity);
        // Read
        TEntity Get(int id);
        // Update
        void Update(TEntity entity);
        // Delete
        void Delete(TEntity entity);
        // Get all
        List<TEntity> GetAll();
    }
    }


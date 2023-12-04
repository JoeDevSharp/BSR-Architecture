using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface Created<TEntity>
    {
        public void Add(TEntity entity);
        public void AddRange(List<TEntity> entities);
    }
}

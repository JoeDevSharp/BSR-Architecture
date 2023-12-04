using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    internal interface Update<TEntity>
    {
        public void Update(TEntity entity);
        public void UpdateRange(List<TEntity> entities);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    internal interface Read<TEntity>
    {
        public List<TEntity> Get(int entityId);
        public List<TEntity> GetAll();
    }
}

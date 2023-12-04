using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    interface Created<TModel>
    {
        public void Add(TModel entity);
        public void AddRange(List<TModel> entities);
    }
}

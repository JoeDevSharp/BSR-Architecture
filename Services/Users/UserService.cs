using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services.Contracts;

namespace Services.Users
{
    public class UserService : Created<UserModel>, Update<UserModel>, Read<UserModel>
    {
        public void Add(UserModel entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<UserModel> entities)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> Get(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAll()
        {
            return AutoMapper.Mapper.Convert<ActiveDirectory.Users, List<UserModel>>(new ActiveDirectory.UserController().GetAll());
        }

        public void Update(UserModel entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<UserModel> entities)
        {
            throw new NotImplementedException();
        }
    }
}

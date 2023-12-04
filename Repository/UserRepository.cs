using Entities;
using Repository.Interfaces;

namespace Repository
{
    public class UserRepository : Created<UserEntity>, Read<UserEntity>, Update<UserEntity>, Deleted<UserEntity>
    {
        public void Add(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<UserEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<UserEntity> entities)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> Get(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<UserEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}

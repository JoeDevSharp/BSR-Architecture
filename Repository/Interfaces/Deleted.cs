namespace Repository.Interfaces
{
    internal interface Deleted<TEntity>
    {
        public void Delete(TEntity entity);
        public void DeleteRange(List<TEntity> entities);
    }
}

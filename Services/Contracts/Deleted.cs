namespace Services.Contracts
{
    internal interface Deleted<TModel>
    {
        public void Delete(TModel entity);
        public void DeleteRange(List<TModel> entities);
    }
}

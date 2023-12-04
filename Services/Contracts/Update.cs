namespace Services.Contracts
{
    internal interface Update<TModel>
    {
        public void Update(TModel entity);
        public void UpdateRange(List<TModel> entities);
    }
}

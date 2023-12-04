namespace Services.Contracts
{
    internal interface Read<TModel>
    {
        public List<TModel> Get(int entityId);
        public List<TModel> GetAll();
    }
}

namespace ApplicationApp.Interfaces
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T obj);
        Task Remove(T obj); 
        Task Delete(T obj);
        Task<T> GetEntityById(T obj);
        Task<List<T>> List();
    }
}

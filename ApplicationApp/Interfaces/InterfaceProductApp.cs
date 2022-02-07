namespace ApplicationApp.Interfaces
{
    public interface InterfaceProductApp : InterfaceGenericApp<Produto>
    {
        Task AddProduct(Produto product);

        Task UpdateProduct(Produto product);
    }
}

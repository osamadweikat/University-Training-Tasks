namespace BrandsShops.Api.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        Task<int> CompleteAsync(); 
    }
}

namespace Apartments.Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> GetbyIdAsync(Guid id, CancellationToken cancellationToken = default);
        void Add(User user);   
    }
}

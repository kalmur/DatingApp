namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get;}
        IMessageRepository MessageRepository {get;}
        ILikesRepository LikesRepository {get;}
        // If one fails -> do not complete
        Task<bool> Complete();
        // Checks if entity framework tracks changes
        bool HasChanges();
    }
}
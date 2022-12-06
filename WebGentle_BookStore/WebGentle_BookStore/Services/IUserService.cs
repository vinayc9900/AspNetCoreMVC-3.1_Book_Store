namespace WebGentle_BookStore.Services
{
    public interface IUserService
    {
        string getUserId();
        bool isAuthenticated();
    }
}
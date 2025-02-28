namespace Module_10;

internal class Program
{
    private static void Main()
    {
        var user = new User();
        var account = new Account();
        IUpdater<Account> updater = new UserService();
        
        var userService = new UserService();
        userService.Update(user);
        userService.Update(account);
    }

    private class User
    {
    }

    private class Account : User
    {
    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    private class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
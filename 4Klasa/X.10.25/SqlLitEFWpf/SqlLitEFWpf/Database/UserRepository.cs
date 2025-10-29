namespace SqlLitEFWpf.Database;

public class UserRepository
{
    public void AddUser(User user)
    {
        using var context = new ApplicationDbContext();
        context.Users.Add(user);
        context.SaveChanges();
    }

    public List<User> GetUsers()
    {
        using var context = new ApplicationDbContext();
        return context.Users.ToList();
    }
}
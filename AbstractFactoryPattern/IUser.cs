namespace AbstractFactoryPattern
{
    public interface IUser
    {
        User GetUser(int id);
        bool InsertUser(User user);
    }
}
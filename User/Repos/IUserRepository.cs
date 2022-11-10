namespace User.Repos
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();
        public Task<User> AddUser(User user);
    }
}

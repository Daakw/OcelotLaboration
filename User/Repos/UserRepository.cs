namespace User.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;
        public static UserRepository Instance;

        public UserRepository()
        {
            if (Instance == null)
            {
                Instance = this;
                _users = new List<User>();

                _users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kalle",
                    LastName = "Anka",
                    EmailAddress = "kallesankdamm@gmail.com"
                });

                _users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Luke",
                    LastName = "Skywalker",
                    EmailAddress = "jediMaster@jedischool.com"
                });

                _users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "hairyfeet@middleearth.com"
                });
            }
        }

        public Task<User> AddUser(User user)
        {
            Instance._users.Add(new User
            {
                Id = Guid.NewGuid(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress
            });
            return Task.FromResult(user);
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(Instance._users);
        }
    }
}

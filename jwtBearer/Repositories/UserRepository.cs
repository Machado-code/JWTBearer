using jwtBearer.Models;

namespace jwtBearer.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "goku", Password = "goku", Role = "manager" });
            users.Add(new User { Id = 2, Username = "vegeta", Password = "vegeta", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}

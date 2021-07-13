


using System.Linq;
using System.Collections.Generic;
using DataLayerClass.Repository.Interface;
using Contract.Model;

namespace DataLayerClass.Repository.Class
{
    public class UserRepository : IUserRepository
    {
        CoreAPIEntities _context = new CoreAPIEntities();
        public UserRepository()
        {
            //_context = context;
        }

        public int CreateUser(IUser userModel)
        {
            _context.Users.Add((User)userModel);
            return _context.SaveChanges();
            

        }

        public int DeleteUser(int UserId)
        {
            _context.Users.Remove((User)GetUser(UserId));
            return _context.SaveChanges();
            

        }

        public IUser GetUser(int UserId)
        {
            return (IUser)_context.Users.First(x => x.UserId == UserId);
            
        }

        public List<User> GetUsers()
        {
            List<User> users = _context.Users.ToList();
            return users;
        }

        public int UpdateUser(IUser userModel)
        {
            _context.Users.Remove((User)userModel);
            return _context.SaveChanges();
            
        }
    }
}

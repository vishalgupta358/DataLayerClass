using Contract.Model;
using System.Collections.Generic;


namespace DataLayerClass.Repository.Interface
{
    interface IUserRepository
    {
        int CreateUser(IUser userModel);
        int UpdateUser(IUser userModel);
        IUser GetUser(int UserId);
        List<User> GetUsers();
        int DeleteUser(int UserId);
    }
}

using Contract.Model;

using DataLayerClass.Repository.Class;
using DataLayerClass.Repository.Interface;
using System.Collections.Generic;


namespace DataLayerClass.FacadeLayer
{

    public class Facade
    {
        private IUserRepository _user = new UserRepository();
        public Facade()
        {
            _user = UserFactoryBuilder.GetUserFactory();
        }

        public int CreateUser(User userdataModel)
        {
            return _user.CreateUser((IUser)userdataModel);
        }

        public IUser GetUser(int Userid)
        {

            return _user.GetUser(Userid);
        }

        public IEnumerable<IUser> GetUsers()
        {
            return (IEnumerable<IUser>)_user.GetUsers();
        }

        public int UpdateUser(User userdataModel)
        {
            return _user.UpdateUser((IUser)userdataModel);
        }

        public int DeleteUser(int Userid)
        {
            return _user.DeleteUser(Userid);
        }


    }

}




using DataLayerClass.Repository.Class;

namespace DataLayerClass.FacadeLayer
{
    public static class UserFactoryBuilder
    {
        private static UserRepository _user = new UserRepository();

        public static UserRepository GetUserFactory()
        {
            return _user;
        }

    }
}

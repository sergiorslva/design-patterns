namespace Singleton
{
    public class SingletonClass
    {
        private static SingletonClass Instance = new SingletonClass();
        private SingletonClass(){}

        public static SingletonClass GetInstance()
        {
            return Instance;
        }
    }
}

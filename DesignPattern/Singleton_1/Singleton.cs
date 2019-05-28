namespace DesignPattern.Singleton_1
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton singleton=new Singleton();

        public static Singleton GetSingleton()
        {
            return singleton;
        }
    }
}

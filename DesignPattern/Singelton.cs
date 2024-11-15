namespace PracticeProject.DesignPattern
{
    public class Singelton
    {
        private static Singelton? Instance = null;
        private static readonly object _lock = new();
        public static Singelton GetInstance()
        {

            if (Instance == null)
            {
                lock (_lock)
                {

                    Instance = new Singelton();
                }
            }
            return Instance;
        }
        private Singelton() { }

    }
}
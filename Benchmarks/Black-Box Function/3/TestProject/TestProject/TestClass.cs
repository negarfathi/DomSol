using System;
namespace TestProject
{
    public class TestClass
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public bool circuit()
        {
            lock (syncLock)
            {
                if (random.NextDouble() < 0.5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int flash()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
        public int nf()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
    }
}
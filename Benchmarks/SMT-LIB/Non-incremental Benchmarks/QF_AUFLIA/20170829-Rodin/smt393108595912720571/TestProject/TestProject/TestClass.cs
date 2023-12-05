using System;
namespace TestProject
{
    public class TestClass
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public int n()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
    }
}
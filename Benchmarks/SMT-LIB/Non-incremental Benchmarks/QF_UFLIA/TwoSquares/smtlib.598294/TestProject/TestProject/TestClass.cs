using System;
namespace TestProject
{
    public class TestClass
    {
        private int S1 = 0;
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public int f1()
        {
            return S1;
        }
        public int f2()
        {
            return S1;
        }
        public int f3()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
        public int f4(int x)
        {
            return S1;
        }
    }
}
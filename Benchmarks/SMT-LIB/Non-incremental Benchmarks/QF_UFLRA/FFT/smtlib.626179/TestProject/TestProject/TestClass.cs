using System;
namespace TestProject
{
    public class TestClass
    {
        private float S1 = 0;
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public float f1()
        {
            return S1;
        }
        public float f2()
        {
            return S1;
        }
        public float f3()
        {
            lock (syncLock)
            {
                return (float)random.NextDouble() * (8 - (-8)) + (-8);
            }
        }
        public float f4()
        {
            lock (syncLock)
            {
                return (float)random.NextDouble() * (8 - (-8)) + (-8);
            }
        }
    }
}
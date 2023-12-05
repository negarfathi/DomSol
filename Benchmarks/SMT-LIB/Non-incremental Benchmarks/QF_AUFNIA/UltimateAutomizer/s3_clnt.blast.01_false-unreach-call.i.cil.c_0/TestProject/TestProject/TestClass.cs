using System;
namespace TestProject
{
    public class TestClass
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public int funAddrssl3_connectbase()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
        public int funAddrssl3_connectoffset()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
    }
}
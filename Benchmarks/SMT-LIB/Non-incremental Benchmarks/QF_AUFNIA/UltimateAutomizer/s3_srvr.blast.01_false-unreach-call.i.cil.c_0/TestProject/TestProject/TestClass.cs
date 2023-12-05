using System;
namespace TestProject
{
    public class TestClass
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public int main_tmalloc1base_8()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
        public int ssl3_accept_tnondet172_12()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
        public int ssl3_accept_ret10_248()
        {
            lock (syncLock)
            {
                return random.Next(-8, 8);
            }
        }
    }
}
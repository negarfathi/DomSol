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
        public bool grn_SR()
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
        public bool org_SR()
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
        public bool prt()
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
        public bool rd1()
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
        public bool rd2()
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
        public bool red_MR()
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
    }
}
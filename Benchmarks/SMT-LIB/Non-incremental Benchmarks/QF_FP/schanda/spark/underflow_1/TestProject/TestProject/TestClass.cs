namespace TestProject
{
    public class TestClass
    {
        public bool is_finite(float x)
        {
            return !float.IsInfinity(x);
        }
        public float f0()
        {
            return 0;
        }
    }
}
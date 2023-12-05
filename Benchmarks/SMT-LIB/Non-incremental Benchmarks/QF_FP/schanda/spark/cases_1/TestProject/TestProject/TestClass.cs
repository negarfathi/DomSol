namespace TestProject
{
    public class TestClass
    {
        public bool is_finite(float x)
        {
            return !float.IsInfinity(x);
        }
    }
}
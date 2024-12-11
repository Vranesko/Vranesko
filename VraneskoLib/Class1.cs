namespace VraneskoLib
{
    public class Class1
    {
        public double Zfunc1(double x, double y, double a)
        {
            return 5 * y + (4 + 2 * a) / (x - 7 * y) + ((a + 1) / (y - 3)) * (3 * a / x);
        }
    }
    public class Class2
    {
        public double Zfunc2(double x, double y, double a)
        {
            return Math.Round(3 * x + (2 - 3 * a) / (8 * x + 3 * a) + 2 + ((a / (y + 1)) + (2 * a / y)) * ((3 - a) / (x + y)));
        }
    }

}

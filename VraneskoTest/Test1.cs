using VraneskoLib;

namespace VraneskoTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            int x = 1;
            int y = 1;
            int a = 1;
            double zf1 = z1.Zfunc1(x, y, a);
            Assert.AreEqual(1, zf1);
            double zf2 = z2.Zfunc2(x, y, a);
            Assert.AreEqual(7, zf2);

        }
    }
    }

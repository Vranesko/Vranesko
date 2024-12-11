using VraneskoLib;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            Console.Title = "Спринт #1 | Выполнил: Вранеско И.Н | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Лабраторная работа #1                                                      *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #9                                                                *");
            Console.WriteLine("* Выполнил: Вранеско Илья Николаевич | МКМб-22-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("X: = 1");
            Console.WriteLine("Y: = 1");
            Console.WriteLine("A: = 1");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("-----------------------");
            int x = 1; int y = 1; int a = 1;
            Console.WriteLine("* Первая функция:                                                            *");
            double zf1 = z1.Zfunc1(x, y, a);
            Console.WriteLine($"z = {zf1}");
            Console.WriteLine("* Вторая функция:                                                            *");
            double zf2 = z2.Zfunc2(x, y, a);
            Console.WriteLine($"z = {zf2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Введите число a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции (1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное)");
                int kodOper = Convert.ToInt32(Console.ReadLine());

                int result;

                switch (kodOper)
                {
                    case 1: result = a + b; break;
                    case 2: result = a - b; break;
                    case 3: result = a * b; break;
                    case 4: result = a / b; break;

                    default: throw new Exception("Не верно выбран код операции");
                }
                Console.WriteLine("Результат:{0}", result);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ошибка:{0}", ex.Message);

            }

            Console.ReadKey();



        }
    }
}

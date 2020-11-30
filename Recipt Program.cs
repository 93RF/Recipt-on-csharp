using System;
using System.Threading.Tasks;

namespace Recipt_Program
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {


            Console.Write("Enter first product name: ");
            string product1 = Console.ReadLine();
            Console.Write("Enter first product price: ");
            double product1p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first product amount: ");
            int product1a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second product name: ");
            string product2 = Console.ReadLine();
            Console.Write("Enter second product price: ");
            double product2p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second product amount: ");
            int product2a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter third product name: ");
            string product3 = Console.ReadLine();
            Console.Write("Enter third product price: ");
            double product3p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third product amount: ");
            int product3a = Convert.ToInt32(Console.ReadLine());

            double total1 = product1a * product1p;
            double total2 = product2a * product2p;
            double total3 = product3a * product3p;
            double sumtotal = total1 + total2 + total3;

            Console.WriteLine("\n--------------------------");
            await Task.Delay(1000);
            Console.WriteLine(" Item " + product1 + " toals to = " + total1);
            await Task.Delay(1000);
            Console.WriteLine(" Item " + product2 + " toals to = " + total2);
            await Task.Delay(1000);
            Console.WriteLine(" Item " + product3 + " toals to = " + total3);
            await Task.Delay(1000);
            Console.WriteLine("\n Sumtotal = " + sumtotal);
            await Task.Delay(1000);
            Console.WriteLine("--------------------------");

        }
    }
}

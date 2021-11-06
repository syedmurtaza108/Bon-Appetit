//Finished in 6 minutes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Appetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => int.Parse(billTemp)).ToList();

            int b = int.Parse(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int annaCost = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                    annaCost += bill[i];
            }
            int actualCost = annaCost / 2;
            int annaShouldPay = b - actualCost;
            if(annaShouldPay != 0)
                Console.WriteLine(annaShouldPay);
            else
                Console.WriteLine("Bon Appetit");
        }
    }
}

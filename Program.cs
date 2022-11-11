using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static public DateTime[] Comparedates(params DateTime[] datesd)
        {

            DateTime[] dateholder = new DateTime[2];

            if (DateTime.Compare(datesd[0], datesd[1]) < 0 || DateTime.Compare(datesd[2], datesd[1]) < 0)
            {
                dateholder[0] = datesd[1];

                dateholder[1] = DateTime.Compare(datesd[2], datesd[0]) < 0 ? datesd[0] : datesd[2];
            }
            else
            {
                dateholder[0] = datesd[0];
                dateholder[1] = datesd[2];
            }
            return dateholder;
        }
        static void Main(string[] args)
        {
            string[] formats = { "yyyyMMdd", "HHmmss", "d.M.yyyy", "dd.MM.yyyy" };
            String str;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime date_1, date_2, date_3;
            date_1 = DateTime.Now;
            date_2 = DateTime.Now;
            date_3 = DateTime.Now;
            DateTime[] dateholder = new DateTime[] { date_1, date_2, date_3 };
            for (int i = 0; i < 3; i++)
            {
                str = Console.ReadLine();
                dateholder[i] = DateTime.ParseExact(str, formats, provider, 0);
            }
            DateTime[] result = Comparedates(dateholder);
            Console.WriteLine(result[0].ToString("dd.MM.yyyy"));
            Console.WriteLine(result[1].ToString("dd.MM.yyyy"));
            Console.WriteLine();
            Console.WriteLine("000");
            Console.WriteLine("Add deb!");
            Console.ReadKey();
        }
    }
}

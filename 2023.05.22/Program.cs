using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._05._22
{
    internal class Program
    {
        static List<Kolcsonzes> orders = new List<Kolcsonzes>();
        static void Main(string[] args)
        {

            /*StreamReader sr = new StreamReader("kolcsonzesek.txt");
            while(!sr.EndOfStream)
            {
                var data = sr.ReadLine().Split(';');
                Kolcsonzes order = new Kolcsonzes(data[0], char.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                orders.Add(order);
            }*/

            orders = File.ReadAllLines("kolcsonzesek.txt").Skip(1).Select(x => new Kolcsonzes(x)).ToList();

            Console.Write("5. feladat: ");
            Console.WriteLine($"Napi kölcsönzések száma: {orders.Count()}");

            Console.Write("6. feladat: Kérek egy nevet: ");
            string name = Console.ReadLine();

            List<Kolcsonzes> specOrders = orders.Where(x => x.Name == name).ToList();
            if (specOrders.Count() == 0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
            }
            else
            {
                Console.WriteLine($"{name} kölcsönzései:");
                specOrders.ForEach(order => Console.WriteLine($"\t{order.TakeoutHour}:{order.TakeoutMinute}-{order.TakebackHour}:{order.TakebackMinute}"));
            }

            // 7.
            Console.Write("7. Feladat: Adjon meg egy időpontot óra:perc alakban: ");
            string inputTime = Console.ReadLine();
            


            // 8.
            int napiBevetel = 2400 * orders.Sum(ob => ob.TimeDistance()) / 30 + 1;
            Console.WriteLine($"8. feladat: A napi bevétel {napiBevetel} Ft");

            // 9.
            StreamWriter sw = new StreamWriter("F.txt");
            orders.Where(x=>x.VehicleId == 'F').ToList().ForEach(x=>sw.WriteLine($"{x.TakeoutHour}:{x.TakeoutMinute}-{x.TakebackHour}:{x.TakebackMinute} : {x.Name}"));
            sw.Close();

            // 10.
            Console.WriteLine("10. feladat: Statisztika");
            orders.GroupBy(x => x.VehicleId).OrderBy(x=>x.Key).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));

            Console.ReadKey();
        }

    }
}

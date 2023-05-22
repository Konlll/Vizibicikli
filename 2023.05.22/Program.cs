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
        static void Main(string[] args)
        {
            List<Kolcsonzes> orders = new List<Kolcsonzes>();

            StreamReader sr = new StreamReader("kolcsonzesek.txt");
            while(!sr.EndOfStream)
            {
                var data = sr.ReadLine().Split(';');
                Kolcsonzes order = new Kolcsonzes(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
            }
        }
    }
}

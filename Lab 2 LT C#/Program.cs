using Lab_2_LT_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Progra
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bai 1a: ");
        Bai1a.Start();
        Console.WriteLine();

        Console.WriteLine("Bai 1b: ");
        Bai1b.bai1b();
        Console.WriteLine();

        Console.WriteLine("Bai 1c: ");
        var user = new UserData(1, 1, "1 st Player");
        user.ShowData();
    }
}



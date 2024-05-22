using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //bai1b

        Console.WriteLine("Bai2a:");
        Console.WriteLine();
        var userInfo = new
        {
            id = "2023",
            name = "Faker",
            isDispay = false,
            bag = new
            {
                skins = 0,
                cups = 0,   
            }
        };
        Console.WriteLine("id" + userInfo.id);
        Console.WriteLine("name" + userInfo.name);
        Console.WriteLine("" + userInfo.isDispay);
        Console.WriteLine("bag" + userInfo.bag. skins);
        Console.WriteLine();

        Console.WriteLine("--------------------------");
        Console.WriteLine();
        //bai2b
        Console.WriteLine("Bai2b:");
        Console.WriteLine();
        int y = 10;
        Action<dynamic> AnonymousMethod = delegate (dynamic x)
        {
            int sum = x + y;
            int sub = x - y;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Sub =" + sub);
        };
        AnonymousMethod(5);
    }
}



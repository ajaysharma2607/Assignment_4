using Assignment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{

    [Flags]
    public enum permission
    {
        read = 1,
        write = 2,
        Execute = 4
    }

    enum Seasons
    {
        spring = 1, summer, monsoon, autumn, winter
    }
    enum Shapes
    {
        Circle = 1, Triangle, Rectangle, Square
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Bank b1 = new Bank("Vipin pandey", 1000);
            b1.getDetails();

            // Question 2
            Car b2 = new Car("audi", "up85", 2022);
            b2.getDetails();

            //Question 3
            Person p1 = new Person("Vipin ", "pandey");
            p1.getDetails();
            Console.ReadKey();

            //Question 4
            Temperature t1 = new Temperature(33);
            t1.convertToFahrenheit();

            //Question 5

            CustomList c1 = new CustomList();
            c1[0] = 12;
            c1[1] = 13;
            Console.WriteLine(c1[0]);
            Console.WriteLine(c1[1]);
            Console.ReadLine();

            // Question 6
            Stack c2 = new Stack();
            c2[0] = 12;
            c2[1] = 13;
            Console.WriteLine(c2[0]);
            Console.WriteLine(c2[0]);
            Console.WriteLine(c2[1]);
            Console.ReadLine();

            // QUestion 7
            Book book = new Book();
            book["title"] = "java";
            Console.WriteLine(book["title"]);
            Console.ReadLine();


            //Question 8
            Console.WriteLine((int)Seasons.spring);
            Console.WriteLine(Seasons.spring);


            Console.WriteLine((int)Seasons.summer);
            Console.WriteLine(Seasons.summer);

            Console.WriteLine((int)Seasons.monsoon);
            Console.WriteLine(Seasons.monsoon);

            Console.WriteLine((int)Seasons.autumn);
            Console.WriteLine(Seasons.autumn);

            // Question 9
            double area = 0;
            Console.WriteLine("Choose the Shape");
            Console.WriteLine("Press 1 for " + Shapes.Circle);
            Console.WriteLine("Press 2 for " + Shapes.Triangle);
            Console.WriteLine("Press 3 for " + Shapes.Rectangle);
            Console.WriteLine("Press 4 for " + Shapes.Square);
            int shape = Convert.ToInt32(Console.ReadLine());

            switch (shape)
            {
                case 1:
                    Console.WriteLine("Enter Rdius ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    Console.WriteLine("Area is :" + area);
                    break;

                case 2:
                    Console.WriteLine("Enter Base and Height");
                    int bases = Convert.ToInt32(Console.ReadLine());
                    int height = Convert.ToInt32(Console.ReadLine());
                    area = (1 / 2) * (bases * height);
                    Console.WriteLine("Area is :" + area);
                    break;
                case 3:
                    Console.WriteLine("Enter lengrh and breadth");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    area = length * breadth;
                    Console.WriteLine("Area is :" + area);
                    break;

                case 4:
                    Console.WriteLine("Enter side of square");
                    int side = Convert.ToInt32(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area is :" + area);
                    break;

                default:
                    Console.WriteLine("Enter Valid input");
                    break;

            }
            Console.ReadLine();

            // Question 10
            Console.WriteLine("enter the which domain you belong as (user,admin,authority) ");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "user":
                    permission us = permission.read;
                    Console.WriteLine($"you only have {us} permission of file :  ");
                    break;
                case "admin":
                    permission ad = permission.read | permission.write;
                    Console.WriteLine($"you  have {ad} permission of file :  ");
                    break;
                case "authority":
                    permission aut = (permission)7;
                    Console.WriteLine($"you only have {aut} permission of file :  ");
                    break;
            }

        }
    }
}










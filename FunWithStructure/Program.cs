using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    class Program
    {
        struct Point
        {

            // fields of the structure
            public int x;
            public int y;

            // add 1 to the (x,y) position
            public void Increment()
            {
                x++; y++;
            }

            //subtract 1 from x and y position
            public void Decrement()
            {
                x--; y--;
            }

            //display the current position
            public void Display()
            {
                Console.WriteLine("X={0}, Y={1}", x, y);
                Console.WriteLine();
            }

            //a custom constructor
            public void CustomConstructor(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("=> a first look at structure");

            //creat an initial point
            Point myPoint;
            myPoint.x = 455;
            myPoint.y = 43;
            myPoint.Display();

            //adjust the x and y values
            myPoint.Increment();
            myPoint.Display();

            //calling custom Constructor
            myPoint.CustomConstructor(50, 60);
            myPoint.Display();

            Console.ReadLine();

        }
    }
}

//Program to implement the point, line segment and check the position of the point

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computational_Geometry
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Line
    {
        public Point p1;
        public Point p2;
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Implementation of the Point P1
            Point p1 = new Point(8, 15);
            //Implementation of the Point P2
            Point p2 = new Point(20, 30);
            //Implementation of the Line from the points P1 and P2
            Line L = new Line(p1, p2);
            Console.WriteLine("-------------------------------------------------------");
            //Display of the Line Segment Edges
            Console.WriteLine("The end points of the Line Segment is:(" + L.p1.x + "," + L.p1.y + ") ,(" + L.p2.x + "," + L.p2.y + ")");
            Console.WriteLine("-------------------------------------------------------");
            //Checking the position of the given points
            Console.WriteLine("\n ***To Check the position of given points:***");
            string user_input = "yes";
            while (user_input != "no")
            {
                Console.WriteLine("\n Enter x and y coordinate of the Point to check its position:");
                string Input = Console.ReadLine();
                string[] Number = Input.Split(',', ' ');
                Point check = new Point(Convert.ToInt32(Number[0]), Convert.ToInt32(Number[1]));
                if (p1.x == check.x && p1.y == check.y)
                {
                    Console.WriteLine("\n The point that you entered lies at the start.");
                }
                else if (p2.x == check.x && p2.y == check.y)
                {
                    Console.WriteLine("\n The point that you entered lies at the terminal.");
                }
                else if (p1.x > check.x)
                {
                    Console.WriteLine("\n The point that you entered lies at the behind.");
                }
                else if (p2.x < check.x)
                {
                    Console.WriteLine("\n The point that you entered lies at the beyond.");
                }
                else
                {
                    Console.WriteLine("\n The point lies between the two points.");
                }
                Console.WriteLine("\n Do you want to Continue?");
                user_input = Console.ReadLine();
            }
        }
    }
}


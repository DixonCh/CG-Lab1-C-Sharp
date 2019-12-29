//Program to Implement Point, Line and Test for Point Line Classification

using System;

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
    class Program
    {
        static void Main(string[] args)
        {
        //int num = 0;
        Start:
            Console.WriteLine("*************************");
            Console.WriteLine("Select your choice: \n \n" +
                "1. Implement Point. \n" +
                "2. Implement Line Segment \n" +
                "3. Test for PLC \n");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("To Implement Point:");
                    Console.WriteLine("*********************");
                    Console.WriteLine("Enter x - coordinate:");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("*********************");
                    Console.WriteLine("Enter y - coordinate:");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("*********************");
                    Console.WriteLine("The  point is:(" + x + "," + y + ")\n \n");
                    break;

                case 2:
                    Console.WriteLine("To implement Line Segment:");
                    Console.WriteLine("Implement starting Point, P0:");

                    Console.WriteLine("*********************");
                    Console.WriteLine("Enter x - coordinate:");
                    int x0 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter y - coordinate:");
                    int y0 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("*********************");
                    Console.WriteLine("The starting point is:(" + x0 + "," + y0 + ")");

                    Console.WriteLine("*********************************");
                    Console.WriteLine("Implement terminal Point, P1:");
                    Console.WriteLine("*********************************");

                    Console.WriteLine("Enter x - coordinate:");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y - coordinate:");
                    int y1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("*******************************************");
                    Console.WriteLine("The terminal point is:(" + x1 + "," + y1 + ")");
                    Console.WriteLine("*******************************************");

                    Console.WriteLine("The Line Segment starts from the point (" + x0 + "," + y0 + ") and terminates at (" + x1 + "," + y1 + ")");
                    Console.WriteLine("******************************************************************");
                    break;

                case 3:

                    Console.WriteLine("To Perform Point Line Classification Test. \n");
                    //Enter x and y coordinates of Starting Point P0
                    Console.WriteLine("\n Enter x and y coordinates of Starting Point P0");
                    string Input = Console.ReadLine();
                    string[] Number = Input.Split(',', ' ');
                    Point p1 = new Point(Convert.ToInt32(Number[0]), Convert.ToInt32(Number[1]));

                    //Enter x and y coordinates of Terminal Point P1
                    Console.WriteLine("\n Enter x and y coordinates of Terminal Point P1");
                    Input = Console.ReadLine();
                    Number = Input.Split(',', ' ');
                    Point p2 = new Point(Convert.ToInt32(Number[0]), Convert.ToInt32(Number[1]));
                    //Implementation of the Line from the points P0 and P1
                    Line L = new Line(p1, p2);
                    Console.WriteLine("-------------------------------------------------------");
                    //Display of the Line Segment Edges
                    Console.WriteLine("The end points of the Line Segment is:(" + L.p1.x + "," + L.p1.y + ") ,(" + L.p2.x + "," + L.p2.y + ")");
                    Console.WriteLine("-------------------------------------------------------");

                    //Checking the position of the given points
                    Console.WriteLine("\n ***To Check the position of given points:***");

                Begin:
                    Console.WriteLine("\n Enter x and y coordinate of the Point to check its position:");
                    string point_input = Console.ReadLine();
                    string[] num_input = point_input.Split(',', ' ');
                    Point check = new Point(Convert.ToInt32(num_input[0]), Convert.ToInt32(num_input[1]));
                    if (check.x > p2.x && check.y > p2.y)
                    {
                        Console.WriteLine("Please enter the valid point.");
                    }
                    else if (check.x < p1.x && check.y < p1.y)
                    {
                        Console.WriteLine("Please enter the valid point.");
                    }
                    else if (check.x == p1.x && check.y == p1.y)
                    {
                        Console.WriteLine("\n The point that you entered lies at the start. \n");
                    }
                    else if (check.x == p2.x && check.y == p2.y)
                    {
                        Console.WriteLine("\n The point that you entered lies at the terminal. \n");
                    }
                    else if (check.x < p1.x || check.y < p1.y)
                    {
                        Console.WriteLine("\n The point that you entered lies at the behind. \n");
                    }
                    else if (check.x > p2.x || check.y > p2.y)
                    {
                        Console.WriteLine("\n The point that you entered lies at the beyond. \n");
                    }

                    else if (check.x > p2.x && check.y > p2.y) {
                        Console.WriteLine("Please enter the valid point.");
                    }
                    else
                    {
                        Console.WriteLine("\n The point lies between the two points. \n");
                    }
                        Decision:
                        Console.WriteLine("Do you want to perform the PLC Test again? \n");
                        string _userDecision = Console.ReadLine();
                         switch (_userDecision.ToUpper())
                        {
                        case "YES":
                            goto Begin;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Your choice is invalid. Please try again. \n");
                            goto Decision;
                        }

                    break;

                default:

                    Console.WriteLine("Your choice {0} is invalid \n", userChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to select the choice again? \n");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again. \n");
                    goto Decide;

            }
        }
    }
}

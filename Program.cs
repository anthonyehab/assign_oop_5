using System.Drawing;
using System;

namespace assign_oop_5
{
    class program
    {
        static void main(string[] args)
        {
            #region project 01
            #region question 1
            //Define 3D Point Class and the basic Constructors (use chaining in constructors).

            // the class is implementation
            #endregion
            #region question 2
            //            Override the ToString Function to produce this output:
            //Point3d P = new Point3d(10, 10, 10);
            //Console.WriteLine(P.ToString()); 


            #endregion
            #region question 3
            //Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).


            //    Point3d P1, P2;

            //    int x1, y1, z1;
            //    string input;

            //    Console.Write("Enter X coordinate for P1: ");
            //    input = Console.ReadLine();
            //    if (int.TryParse(input, out x1))
            //    {
            //        Console.Write("Enter Y coordinate for P1: ");
            //        input = Console.ReadLine();
            //        if (int.TryParse(input, out y1))
            //        {
            //            Console.Write("Enter Z coordinate for P1: ");
            //            input = Console.ReadLine();
            //            if (int.TryParse(input, out z1))
            //            {
            //                P1 = new Point3d(x1, y1, z1);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input for Z coordinate. Using default value 0.");
            //                P1 = new Point3d(x1, y1, 0);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input for Y coordinate. Using default value 0.");
            //            P1 = new Point3d(x1, 0, 0);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for X coordinate. Using default value 0.");
            //        P1 = new Point3d(0, 0, 0);
            //    }

            //    int x2, y2, z2;

            //    Console.Write("Enter X coordinate for P2: ");
            //    input = Console.ReadLine();
            //    try
            //    {
            //        x2 = int.Parse(input);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input for X coordinate. Using default value 0.");
            //        x2 = 0;
            //    }

            //    Console.Write("Enter Y coordinate for P2: ");
            //    input = Console.ReadLine();


            //        y2 = int.Parse(input);



            //        Console.WriteLine("Invalid input for Y coordinate. Using default value 0.");
            //        y2 = 0;


            //    Console.Write("Enter Z coordinate for P2: ");
            //    input = Console.ReadLine();
            //    try
            //    {
            //        z2 = int.Parse(input);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input for Z coordinate. Using default value 0.");
            //        z2 = 0;
            //    }

            //    P2 = new Point3d(x2, y2, z2);

            //    Console.WriteLine($"P1 Coordinates:  {P1.ToString()}");
            //    Console.WriteLine($"P2 Coordinates:   {P2.ToString()}");
            //}
            #endregion
            #region question 4
            //Try to use ==       If(P1 == P2)   Does it work properly? 
        
            Point3d P1 = new Point3d(1, 2, 3);
            Point3d P2 = new Point3d(1, 2, 3);

            if (P1 == P2)
            {
                Console.WriteLine("P1 and P2 are equal");
            }
            else
            {
                Console.WriteLine("P1 and P2 are not equal");
            }

            #endregion
            #region question 5
            //Define an array of points and sort this array based on X & Y coordinates.



            //     Point3d[] points = new Point3d[]
            //{
            //     new Point3d(3, 4, 5),
            //     new Point3d(1, 2, 3),
            //     new Point3d(2, 3, 4),
            //     new Point3d(4, 1, 2),
            //     new Point3d(2, 1, 3)
            //};

            //     Array.Sort(points, (a, b) =>
            //     {
            //         if (a.X != b.X)
            //             return a.X.CompareTo(b.X);
            //         else
            //             return a.Y.CompareTo(b.Y);
            //     });

            //     foreach (var point in points)
            //     {
            //         Console.WriteLine(point.ToString());
            //     }


            #endregion
            #region question 6
            //Implement ICloneable interface to be able to clone the object.


            //Point3d p1 = new Point3d(1, 2, 3);
            //Point3d p2 = (Point3d)p1.Clone();

            //Console.WriteLine(p2.ToString());



            #endregion

            #endregion
            #region project 02

            //Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ()

            //Maths maths = new Maths();

            //int resultAdd = maths.Add(5, 3);
            //Console.WriteLine(resultAdd );

            //int resultSubtract = maths.Subtract(5, 3);
            //Console.WriteLine( resultSubtract);

            //int resultMultiply = maths.Multiply(5, 3);
            //Console.WriteLine( resultMultiply);

            //double resultDivide = maths.Divide(5, 3);
            //Console.WriteLine( resultDivide);


            #endregion
            #region project 03
            // the implementation in the duration class

            #endregion

        }



    }
}



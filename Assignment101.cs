using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            int length; int width;
            rectangle obj = new rectangle();

            while (value == false)
            {
                Console.WriteLine("hello");
                Console.WriteLine("Please choose one from the following:");
                Console.WriteLine("\n 1.GetRectangleLength \n 2.ChangeRectangleLength \n 3.GetRectangleWidth \n 4.ChangeRectangleWidth \n 5.Get Rectangle Perimeter \n 6.Get Rectangle Perimeter.");
                String options = Console.ReadLine();
                Console.WriteLine(" ");
                switch (options)
                {
                    case "1":
                        int getlength = obj.GetLength();
                        Console.WriteLine("Length of the Rectangle is {0}", getlength);
                        break;
                    case "2":
                        Console.WriteLine("Enter Length");
                        length = Convert.ToInt32(Console.ReadLine());
                        if (length <= 0)
                        {
                            Console.WriteLine("Length should bt greater than 0");
                            Console.WriteLine("Enter Length");
                            length = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Length of the Rectangle is {0}", length);
                        }
                        else
                        {
                            obj.SetLength(length);
                            Console.WriteLine("Entered length is set to {0}", obj.GetLength);
                            Console.WriteLine("");
                        }
                        break;
                    case "3":
                        int getwidth = obj.GetWidth();
                        Console.WriteLine("Width of th Rectangle is {0}", getwidth);
                        break;
                    case "4":
                        Console.WriteLine("Enter Width");
                        width = Convert.ToInt32(Console.ReadLine());
                        if (width <= 0)
                        {
                            Console.WriteLine("Width should bt greater than 0");
                            Console.WriteLine("Enter Width");
                            width = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Width of the Rectangle is {0}", width);
                        }
                        else
                        {
                            obj.SetWidth(width);
                            Console.WriteLine("Entered width is set to {0}", obj.GetWidth);
                            Console.WriteLine("");
                        }
                        break;
                    case "5":
                        int Perimeter = obj.GetPerimeter();
                        Console.WriteLine("Perimeter of the Rectangle is {0}", Perimeter);
                        break;
                    case "6":
                        int Area = obj.GetArea();
                        Console.WriteLine("Area of the Rectangle is {0}", Area);
                        break;
                    case "7":
                        Console.WriteLine("Exit.");
                        value = true;
                        break;
                }
            }
        }
    }

}

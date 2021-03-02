using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, option;
            Rectangle rectangle = new Rectangle();
            length = width = option = 0;
            while (length <= 0)
            {
                Console.Write("Please enter the length of the rectangle (Must be greater than 0 and an integer): ");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length > 0)
                    {
                        rectangle.SetLength(length);
                    }
                }
                catch (FormatException fe)
                {
                    length = -1;
                }
            }
            while (width <= 0)
            {
                Console.Write("Please enter the width of the rectangle (Must be greater than 0 and an integer): ");
                try
                {
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width > 0)
                    {
                        rectangle.SetWidth(width);
                    }
                }
                catch (FormatException fe)
                {
                    width = -1;
                }
            }
            if (width > 0 && length > 0)
            {
                while (option <= 0 || option > 7)
                {
                    Console.WriteLine("Please input the number corresponding to the selected option on the menu below:\n" +
                                    "1. Get Rectangle Length\n" +
                                    "2. Change Rectangle Length\n" +
                                    "3. Get Rectangle Width\n" +
                                    "4. Change Rectangle Width\n" +
                                    "5. Get Rectangle Perimeter\n" +
                                    "6. Get Rectangle Area\n" +
                                    "7. Exit\n");
                    try
                    {
                        int newValue = 0;
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine($"Rectangle length is: {rectangle.GetLength()}");
                                option = 0;
                                break;
                            case 2:
                                Console.Write("Enter new value for rectangle length (Must be greater than 0 and an integer): ");
                                try
                                {
                                    newValue = Convert.ToInt32(Console.ReadLine());
                                    if (newValue > 0)
                                    {
                                        rectangle.SetLength(newValue);
                                        option = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Value not greater than 0!");
                                        option = 0;
                                    }
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("Wrong input format!");
                                    option = 0;
                                }
                                break;
                            case 3:
                                Console.WriteLine($"Rectangle width is: {rectangle.GetWidth()}");
                                option = 0;
                                break;
                            case 4:
                                Console.Write("Enter new value for rectangle width (Must be greater than 0 and an integer): ");
                                try
                                {
                                    newValue = Convert.ToInt32(Console.ReadLine());
                                    if (newValue > 0)
                                    {
                                        rectangle.SetWidth(newValue);
                                        option = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Value not greater than 0!");
                                        option = 0;
                                    }
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("Wrong input format!");
                                    option = 0;
                                }
                                break;
                            case 5:
                                Console.WriteLine($"Rectangle perimeter is: {rectangle.GetPerimeter()}");
                                option = 0;
                                break;
                            case 6:
                                Console.WriteLine($"Rectangle area is: {rectangle.GetArea()}");
                                option = 0;
                                break;
                            case 7:
                                Environment.Exit(-1);
                                break;
                        }
                    }
                    catch (FormatException fe)
                    {
                        option = -1;
                    }
                }


            }
            Console.ReadLine();

        }
    }
}

using System;

namespace LabeOneRemake
{
    class Program
    {
        static void Main(string[] args)
        
        {

            bool input = true;

            // Input while loop

            while (input)

            {
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine()); 
                


                double area = length * width;
                double perimeter = 2 * (length + width);
                double tilesArea = area / 5;
                double paintPerimeter = perimeter / 5;
                double volume = length * height * width;
                double paintWalls = (area + 2 * length * height + 2 * width * height) / 5;

                //Finding the Area of the classroom: 

                Console.WriteLine("Area: " + area);

                //Finding the Perimeter of the classroom: 

                Console.WriteLine("Perimeter: " + perimeter);

                //How much tiles are needed: 

                Console.WriteLine("Carpet Tiles: " + tilesArea);

                // How much paint is needed: 

                Console.WriteLine("Paint: " + paintPerimeter);

                // Finding volume of room: 

                Console.WriteLine("Volume: " + volume);

                // Finding paint wall: 

                Console.WriteLine($"Paint Walls: {paintWalls}");

                Console.WriteLine("Continue!  (y/n) ");

                string yes = Console.ReadLine();  

                if (yes == "Y" || yes == "y") 
                {
                    input = true; 
                } else
                {
                    input = false; 
                }

            }
            
        }
    }
}

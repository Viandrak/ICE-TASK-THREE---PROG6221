namespace ICE_TASK_THREE___PROG6221
{
    internal class Program // VIANDRA KISTASAMY - ST10445089
    {
        static void Main(string[] args)
        {
            // Create a Rectangle
            Rectangle rectangle = new Rectangle("My Rectangle", 5, 10);
            rectangle.Display();
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

            // Create a Circle
            Circle circle = new Circle("My Circle", 7);
            circle.Display();
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}




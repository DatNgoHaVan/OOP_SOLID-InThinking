namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 5);
            Console.WriteLine(rect.GetArea()); // The area will be 4*5=20 => correct
            // Now replace with a square which is inherited from Rectangle
            // and change the width
            rect = new Square();
            rect.Width = 10;
            int area = rect.GetArea();
            Console.WriteLine($"New area: {area}"); // The area will be 10*10=100 instead of 10*5=50
            // Or use rect as a param for a logic method which may occur in real world
            checkValidChangeSizeRectangle(rect); // It will throw an Exception
        }

        private static void checkValidChangeSizeRectangle(Rectangle r)
        {
            r.Width = 5;
            r.Height = 4;
            // Because "r" is a Rectangle, we expect that the result will be 4*5=20
            // but the result will be 4*4=16
            if (r.GetArea() != 20)
                throw new Exception("It returns a bad area");
        }
    }
}

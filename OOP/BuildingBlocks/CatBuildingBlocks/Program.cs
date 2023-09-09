namespace CatBuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Persian is an instance of CAT
            CatClass persian = new CatClass("Pikachu", "Persian", "5-month");
            persian.Meow();
            persian.Eat();
            persian.Sleep();
        }
    }
}

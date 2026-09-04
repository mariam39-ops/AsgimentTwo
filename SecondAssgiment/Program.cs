namespace SecondAssgiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer1
            int Pages = 464;
            bool isAvailabel = true;
            if (Pages > 300 && isAvailabel == true)
            {

                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("no you can't borrow this book");
            }
        }
    }
}

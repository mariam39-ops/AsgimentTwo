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
            //answer 2
    
            string title = "Refactoring";
            switch (title)
            {
                case "clean code":
                    Console.WriteLine("!Great choice");
                    break;
                case "Refactoring ":
                    Console.WriteLine("Nice pick");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
          
            
            
            }
            //answer 3
            string sizeLabel = Pages > 300 ? "Long book" : "short book";
            //answer 4
            string[] books = { "clean code", "the pragmatic", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }
            //answer 5
            int e = 0;
            while (e < books.Length)
            {
                Console.WriteLine(books[e]);
                e++;
            }

        }
  



    }
}

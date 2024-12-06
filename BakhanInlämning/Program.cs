namespace Bakhaninlämning{
    class Program{
        public static void Main(){
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lägg till data");
            Console.WriteLine("2. Läs data");
            
            var input = Console.ReadLine();

            if (input == "1")
            {
                AddData.Run();
            }
            else if (input == "2")
            {
                ReadData.Run();
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }
        }
    }
}
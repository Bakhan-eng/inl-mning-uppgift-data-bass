using Models;

namespace Bakhaninlämning{
    class Program{
        public static void Main(){

            Seed.Run();
            
            while(true){

                Console.WriteLine("Vad vill du göra?");

                Console.WriteLine("1. Lägg till Bok och författare");
                Console.WriteLine("2. Låna bok");
                Console.WriteLine("3. Lista alla böccker");
                Console.WriteLine("4. Lämna tillbaka bok");
                Console.WriteLine("5. Ta bort bok");
            
                var input = Console.ReadLine();

                if (input == "1")
                {
                    AddData.Run();
                }
                else if(input == "2"){
                    LoanBook.Run();
                }
                else if (input == "3")
                {
                    ReadData.Run();
                }
                else if (input == "4"){
                    ReturnBook.Run();
                }
                else if(input == "5"){
                    RemoveBook.Run();
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
            }
        }
    }
}
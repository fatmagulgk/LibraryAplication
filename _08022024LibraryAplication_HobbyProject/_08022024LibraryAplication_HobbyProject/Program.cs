using System.Diagnostics.Tracing;

namespace _08022024LibraryAplication_HobbyProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            BookManager.CreateBookAndListAdd();
            BookManager.BooksTitleAndIDList();
            Console.WriteLine("1.Ekleme" + "\n" + "2.Silme" + "\n" + "3.Detay Gösterme" + "\n" + "Hangi işlemi yapmak istiyorsunuz?");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                BookManager.AddBook();
            }
            else if (input == 2)
            {

            }
            
        }
       
        
       
        
    }
}

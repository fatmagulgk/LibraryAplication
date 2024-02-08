using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08022024LibraryAplication_HobbyProject
{
    public static class BookManager
    {
        public static List<Book> books = new List<Book>();
        public static void CreateBookAndListAdd()
        {
            Book b1 = new Book(1, "Kül Kedisi", "Anonim", new DateTime(2000, 01, 01), 80, BookType.Roman);
            Book b2 = new Book(2, "Kısa Hikayeler", "Various Authors", new DateTime(2015, 05, 10), 120, BookType.KısaHikaye);
            Book b3 = new Book(3, "Şiir Seçkisi", "Modern Poets", new DateTime(2005, 03, 20), 50, BookType.Poetri);
            Book b4 = new Book(4, "Steve Jobs Biyografisi", "Walter Isaacson", new DateTime(2011, 09, 05), 300, BookType.Biyografi);
            Book b5 = new Book(5, "Dünya Tarihi", "Various Historians", new DateTime(2008, 12, 15), 400, BookType.Tarih);
            Book b6 = new Book(6, "Felsefi Düşünceler", "Philosophers Union", new DateTime(1990, 06, 22), 180, BookType.Felsefe);
            Book b7 = new Book(7, "Bilim Kurgu Öyküleri", "Sci-Fi Writers", new DateTime(2020, 02, 08), 250, BookType.BilimKurgu);
            Book b8 = new Book(8, "Fantastik Dünya", "Fantasy Masters", new DateTime(1985, 11, 12), 350, BookType.Fantastik);
            Book b9 = new Book(9, "Eğitimde Yenilikler", "Education Experts", new DateTime(2019, 07, 01), 200, BookType.Eğitim);
            Book b10 = new Book(10, "Mitoloji Ansiklopedisi", "Mythology Scholars", new DateTime(2003, 04, 18), 280, BookType.Mitoloji);

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);
            books.Add(b5);
            books.Add(b6);
            books.Add(b7);
            books.Add(b8);
            books.Add(b9);
            books.Add(b10);

        }
        public static void BookDetailWrite()
        {
            foreach (var book in books)
            {

                Console.WriteLine(book.GetID() + "--" + book.GetTitle() + "--" + "Yazar : " + book.GetAuthor() + "--" + "Basım Yılı : " + book.GetPublicationYear() + "--" + "Sayfa Sayısı: " + book.GetPageCount());
            }
        }

        public static void BooksTitleAndIDList()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.GetID() + "." + book.GetTitle());
            }
        }
        public static void AddBook()
        {
            Console.WriteLine("Id giriniz.");
            int _id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitap başlığını giriniz");
            string _title = Console.ReadLine();
            Console.WriteLine("Kitap yazarını giriniz");
            string _author = Console.ReadLine();
            Console.WriteLine("Basım tarihini giriniz:");
            DateTime _history = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Sayfa sayısını giriniz :");
            int _pageCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Roman" + "\n" + "2.KısaHikaye" + "\n" + "3.Poetri" + "\n" + "4.Biyografi" + "\n" + "5.Tarih" + "\n" + "6.Felsefe" + "\n" + "7.BilimKurgu" + "\n" + "8.Fantastik" + "\n" + "9.Eğitim" + "\n" + "10.Din" + "\n" + "11.Mitoloji" + "Lütfen kitap türünüz hangi madde içindeyse belirtiniz");
            int article = Convert.ToInt32(Console.ReadLine());
            BookType _type;
            switch (article)
            {
                case 1:
                    _type = BookType.Roman;
                    break;
                case 2:
                    _type = BookType.KısaHikaye;
                    break;
                case 3:
                    _type = BookType.Poetri;
                    break;
                case 4:
                    _type = BookType.Biyografi;
                    break;
                case 5:
                    _type = BookType.Tarih;
                    break;
                case 6:
                    _type = BookType.Felsefe;
                    break;
                case 7:
                    _type = BookType.BilimKurgu;
                    break;
                case 8:
                    _type = BookType.Fantastik;
                    break;
                case 9:
                    _type = BookType.Eğitim;
                    break;
                case 10:
                    _type = BookType.Din;
                    break;
                case 11:
                    _type = BookType.Mitoloji;
                    break;
                default:
                    _type = BookType.None;
                    break;
            }
            Book book = new Book(_id, _title, _author, _history, _pageCount, _type);
            books.Add(book);

            Console.WriteLine(book.GetTitle());
        }
    }
}

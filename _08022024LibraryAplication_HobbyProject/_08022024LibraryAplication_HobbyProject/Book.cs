using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08022024LibraryAplication_HobbyProject
{
    public  class Book
    {
        int ID;
        string Title;
        string Author;
        DateTime PublicationYear;
        int PageCount;
        BookType Type;
        //BookType eklenecek bunun için enum kullanılabilir.
        public Book(int _id,string _title,string _author,DateTime _publicationYear,int _pageCount,BookType _type)
        {
            ID = _id;
            Title = _title;
            Author = _author;
            PublicationYear = _publicationYear;
            PageCount = _pageCount;
            Type = _type;
        }

        public int GetID()
        {
            return ID;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public int GetPublicationYear()
        {
            return PublicationYear.Year;
        }
        
        public int GetPageCount()
        {
            return PageCount;
        }
        public BookType GetBookType()
        {
            return Type;
        }
        
    }
    public enum BookType
    {
        None,
        Roman,
        KısaHikaye,
        Poetri,
        Biyografi,
        Tarih,
        Felsefe,
        BilimKurgu,
        Fantastik,
        Eğitim,
        Din,
        Mitoloji

    }

    public enum UserOperation
    {
        None,
        Adding,
        Deletion,
        DetailView

    }
}

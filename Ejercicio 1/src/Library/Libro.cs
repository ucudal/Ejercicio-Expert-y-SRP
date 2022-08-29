using System;

namespace SRP
{
    public class Book
    {        
        //Esta clase no cumple con el principio SRP
        //Porque tiene 2 responsabilidades
        // Conocer el libro (Método Book)
        // Archivar el libro (Método ShelveBook)

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */

        
    }
    public class ShelveBook
    {
        
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public ShelveBook(String title, String author, String code, String sector, String shelve)
        {
            Book book = new Book(title, author, code);
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}

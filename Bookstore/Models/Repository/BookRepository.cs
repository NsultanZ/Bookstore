using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.Repository
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
             {
                 new Book
                 {
                     Id=1, Titel="c# programing", Description="no description"
                 },

                 new Book
                 {
                     Id=2, Titel="java programing", Description="nothing"
                 },

                 new Book
                 {
                     Id=3, Titel="python programing", Description="no data"
                 },

             };
        }
        
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);

            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id,Book NewBook)
        {
            var book = Find(id);
            book.Titel = NewBook.Titel;
            book.Description = NewBook.Description;
            book.Author = NewBook.Author;
        }
    }
}

using LibraryApplication.Data;
using LibraryApplication.Models;
using LibraryApplication.Services.Implementations;
using System;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorService authorService = new AuthorService();
            BookService bookService = new BookService();

            Author author1 = new Author("Lev", "Tolstoy", 55);
            Author author2 = new Author("Fyodor", "Dostoevski", 60);

            Book book1 = new Book("Anna Karenina", 800);
            Book book2 = new Book("Karamazov Brothers", 600);

            author1.Books.Add(book1);
            author2.Books.Add(book2);

            book1.Author = author1;
            book2.Author = author2;

            authorService.Create(author1);
            authorService.Create(author2);

            bookService.Create(book1);
            bookService.Create(book2);


            
            Console.WriteLine("res 1");
            bookService.GetAll();
            Console.WriteLine("res2");
            bookService.Delete("Anna Karenina");
        }
    }
}

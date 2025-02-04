using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace OopsPrograms
{
    internal class Book
    {
        int bookId;
        string bookName;
        string author;
        public Book()
        {

        }
        public int BookId { get { return bookId; } }
        public string BookName { get { return bookName; } }
        public string Author { get { return author; } }
        public Book(int bookId,string bookName,string author)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.author = author;
        }
    }
    internal class Library :Book 
    {
        List<Book> b = new List<Book>();
        public void AddBook(Book book)
        {
            b.Add(book);
        }
        public void RemoveBook(int Id)
        {
            Book bookToRemove = b.Find(b => b.BookId == Id);
        }

        public void Display()
        {
            foreach (Book book in b)
            {
                Console.WriteLine("Book Id : " + book.BookId);
                Console.WriteLine("Book Name : " + book.BookName);
                Console.WriteLine("Author : " + book.Author);
            }
        }
    }
}

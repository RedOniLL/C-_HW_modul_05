using System;

namespace C__HW_modul_05
{
    public class ReadingList
    {
        private string[] books;
        private int count;

        public ReadingList(int capacity)
        {
            books = new string[capacity];
            count = 0;
        }

        public void AddBook(string book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
            }
            else
            {
                Console.WriteLine("The reading list is full.");
            }
        }

        public void RemoveBook(string book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i] == book)
                {

                    for (int j = i; j < count - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    count--;
                    return;
                }
            }
            Console.WriteLine("The book is not found in the reading list.");
        }

        public bool ContainsBook(string book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i] == book)
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("The reading list is empty.");
                return;
            }

            Console.WriteLine("Reading List:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("- " + books[i]);
            }
        }
    }

}

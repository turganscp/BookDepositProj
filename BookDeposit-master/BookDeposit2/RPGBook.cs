using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDeposit2
{
    class RPGBook
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Pages;
        public int ISBN;

        public RPGBook(string title, string author, string genre, int pages, int isbn)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Pages = pages;
            ISBN = isbn;
        }


    }
}

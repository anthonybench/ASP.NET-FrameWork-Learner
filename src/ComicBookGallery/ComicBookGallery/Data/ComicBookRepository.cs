using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {

        // return a ComicBook with matching id
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in Data.ComicBooks)
            {
                if (comicBook.ID == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }

        // return a all ComicBook's
        public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }
    }
}
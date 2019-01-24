using System;
using System.Collections.Generic;
using System.Linq;

namespace BookWeb.Models.Logic
{
    public class BookLogic
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private readonly Func<BookDbContext> _dbContext = () => new BookDbContext();

        public List<Book> GetBook()
        {
            using (var context = _dbContext.Invoke())
            {
                var bookList = from b in context.Books select b;
                return bookList.ToList();
            }
        }
    }
}
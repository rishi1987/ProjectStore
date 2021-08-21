using BokkProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BokkProject.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }
        public BookModel GetSingleBook(int id)
        {
            return Datasource().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> SerachBook(string title, string author)
        {
            return Datasource().Where(x => x.title.Contains(title) || x.author.Contains(author)).ToList();
        }
        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel() { id=1,title="C",author="Rishi"},
                new BookModel() { id = 2, title = "Java", author = "Volvo" },
                new BookModel() { id = 3, title = "C++", author = "Bejos" },
                new BookModel() { id = 4, title = "Python", author = "Burk" },
                new BookModel() { id = 5, title = "Node", author = "Rishi" }
            };
        }
    }
}

using BokkProject.Models;
using BokkProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BokkProject.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _bookRepository = null;

        public BookController()
        
        {
            _bookRepository = new BookRepository();
        }

        //public List<BookModel> getAllBooks()
        //{
        //   return _bookRepository.GetAllBooks();
        //}


        public ViewResult GetAllBooks()
        {
            return View();
        }
        public BookModel getSingleBook(int id)
        {
            return _bookRepository.GetSingleBook(id);
        }

        public List<BookModel> searchBook(string title, string author)
        {
            return _bookRepository.SerachBook(title, author);
        }
    }
}

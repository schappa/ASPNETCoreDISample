using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreDISample.Contracts;
using ASPNETCoreDISample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBooksRepository m_booksRepository = null;

        public BooksController(IBooksRepository booksRepo)
        {
            m_booksRepository = booksRepo;
        }

        // GET: api/Books
        [HttpGet]
        public List<Book> Get()
        {
            return m_booksRepository.GetAll();
        }   
        
        //public List<Book> GetAllBooks([FromServices]IBooksRepository booksRepo)
        //{
        //    return booksRepo.GetAll();
        //}
    }
}

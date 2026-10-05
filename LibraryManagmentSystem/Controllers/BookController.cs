using LibraryManagmentSystem.Models;
using LibraryManagmentSystem.Repos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGenericRepo<Book> _context;

        public BookController(IGenericRepo<Book> context)
        {
            _context = context;
        }
        
    }
}

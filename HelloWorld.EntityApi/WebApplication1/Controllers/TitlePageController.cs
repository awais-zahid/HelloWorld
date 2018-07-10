using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class TitlePageController : ControllerBase
    {
        private readonly TitlePageContext _context;

        public TitlePageController(TitlePageContext context)
        {
            _context = context;

            if (_context.titlePage.Count() == 0)
            {
                _context.titlePage.Add(
                    new TitlePage
                    {
                        pageTitle = "Hello World",
                        author ="Muhammad Awais Zahid"
                    }
                );
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<TitlePage> GetAll()
        {

            return _context.titlePage.ToList();
        }
    }
}